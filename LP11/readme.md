# Learning Period 11
### Sherlock Ollama integration

I’ve been using [Sherlock](https://github.com/Skxxtz/sherlock) for a while now, and since it’s a Rust project that’s still pretty new, I figured it would be a good chance to brush up on my Rust skills. 
I’ve never actually built a desktop app with an interface in Rust before, so even though this extension isn’t a full application on it's own, it feels like a good stepping stone toward the kind of project I eventually want to make - actual Rust based desktop applications with actual UIs.

I also think that I'm not at the level yet where I can build something like that so improving my Rust skills on a project that is essentially what I wanna make in the future is the perfect chance for me. 
Also Sherlock doesn't have much of a documentation yet so I'll have to read through a lot of code from another person. (which will be a first for me) 

I think that's why I can gain great insights into how to build applications with Rust in this LP.

I've also never really contributed to an OSS project before which is something I've been wanting to do for a long time. 

(I've already made an easier extension for Sherlock just to get the hang of it - basically just currency exchange API calls and regex)
[Link here](https://github.com/reazndev/SherlockCurrencyConverter)

---

TLDR; Rust based Ollama AI integration for [Sherlock](https://github.com/Skxxtz/sherlock) app launcher (kind of an extension for it) so I can ask AI with a single button press, without having to open a browser and of course all locally so OpenAI/Claude/Google won't use them against me in court one day :)

## 22.08

- [ ] Find out how to use modifier + enter without it closing Sherlock
- [ ] initial setup, create fallback.json config -> test output for ai to test
- [X] call ollama from project
- [ ] feat: option to add default LLM

Today I've had a lot of issues with how Sherlock handles specific binds. Since Sherlock doesn't have a documentation for developing plugins yet I have to try to reverse engineer everything which is quite annoying. However I was able to send requests to Ollama from a Rust project. While this is just a simple API request it's the first time I've worked with Ollama's API.

My issues is that the launcher type "bulk_text" which I need so I can format the AI output nicely with markdown doesn't seem to work well with any binds at all so I currently have the issue that I can't send the request to Ollama via the API on modifier + Return for example. I'm not quite sure how I can fix or circumnavigate this but I'll ask the creator of Sherlock if bulk_text + binds that execute commands / functions that aren't defined in the src of Sherlock itself is even possible. 

```Rust
use reqwest::Client;
use serde::Deserialize;
use futures_util::StreamExt;

#[derive(Deserialize, Debug)]
struct OllamaStreamResponse {
    response: Option<String>,
    done: Option<bool>,
}

#[tokio::main]
async fn main() -> Result<(), Box<dyn std::error::Error>> {
    let model = "gemma3:4b";
    let prompt = "How many r's are in strawberry";

    let client = Client::new();
    let url = "http://localhost:11434/api/generate";

    let resp = client
        .post(url)
        .json(&serde_json::json!({
            "model": model,
            "prompt": prompt
        }))
        .send()
        .await?;

    if !resp.status().is_success() {
        eprintln!("API error: {}", resp.text().await?);
        return Ok(());
    }

    let mut stream = resp.bytes_stream();

    let mut buffer = Vec::new();

    while let Some(item) = stream.next().await {
        let chunk = item?;
        buffer.extend_from_slice(&chunk);

        while let Some(pos) = buffer.iter().position(|&b| b == b'\n') {
            let line = buffer.drain(..=pos).collect::<Vec<_>>();
            let line_str = String::from_utf8_lossy(&line);

            if let Ok(parsed) = serde_json::from_str::<OllamaStreamResponse>(&line_str) {
                if let Some(resp_text) = parsed.response {
                    print!("{}", resp_text);
                }
                if parsed.done == Some(true) {
                    println!("\n--- done ---");
                    return Ok(());
                }
            }
        }
    }

    Ok(())
}

```

## 22.08

- [ ] I want the user to send a simple API request when using the plugin
- [ ] I want the user to send an API request to their local Ollama instance when using the plugin
- [ ] I want the user to be able to add a standard model when using the plugin


### Challenges I might (and will) face
- Enter executes an app (closes the launcher) but I need the enter input to send out the prompt to Ollama
- Error: Time out exceeded -> if nothing happens (AI requests takes a bit based on the PC) Sherlock will time it out and automatically cancell the request
- Formatting (Sherlock height is fixed so I'll probably have to add 'system prompts'? if not to exceed a certain length so it can be shown nicely.
- Copy response (is theoretically possible but unsure how as of now) -> copy specific part of response instead of everything -> maybe split each paragraph
- Speed of Ollama
- Other Ollama related issues like need to execute `Ollama serve` at system start to even start Ollama, not sure if this can be automated by Rust or if this is even wished for since it'd change daemon settings -> needs sudo -> people might be unhappy with that
