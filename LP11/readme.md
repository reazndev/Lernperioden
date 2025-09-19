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

## 29.08

- [X] I want the user to send a simple API request when using the plugin
- [ ] I want the user to send an API request to their local Ollama instance when using the plugin
- [ ] I want the user to be able to add a standard model when using the plugin

✍️ Today I was able to find a workaround for the enter/return problem. I initially tried to copy the logic from the media_player module within sherlock however I realised that, this logic doesn't work for plugins as they're used differently compared to native modules which are just called by the function names instead of just calling the binary (plugins work that way). However this took some time and now we run into another issue - timeout exceeded. This probably is an easy fix with just sending '.' '..' '...' while the Ollama is doing its magic but I haven't had the time yet to try out this approach. The code is now uploaded here: https://github.com/reazndev/sherlock-ollama

*technically we're already sending an API request to Ollama which also starts but it stops after 3 seconds when Sherlock reaches the timeout* 

## 05.09
I have a job interview at 15:00 so I'll just hope I get the job and I'll work on my project in the upcoming week :+1:

## 12.09

> After contemplating, checking the source code and talking with the developer of Sherlock I've realised that it's almost impossible to implement Ollama into it for one main reason.
> 
> After 3 seconds Sherlock hits you with a timeout which will stop the entire window. I've tried to find a work around with sending a loading animation but that only works for about 10-15 seconds and and when keeping in mind that depening on the GPU and the ?> model the request times are 20 - 40 seconds it's simple not possible or viable to implement Ollama. The only solution would be to change the timeout mechanism within Sherlock itself however I'm not confident enough in my Rust abilities and general CS abilities to try and fix this and create a PR for it. 

> Hence I've decided to switch my project to something I've been meaning to do for a long time but just never found the time and motivation. 
> I want to create my own Matrix client since I'm not entirely satisfied with Element, Schildinext, Clinny or Fluffychat. I've decided that taking on a big project like that where I have to work with e2ee, caching, crates, async operations and much more would > be the best way to improve my overal coding abilities. Since the focus shouldn't be on frontend for now but rather on the Rust backend code I've decided to make a TUI with the help of [Ratatui](https://ratatui.rs/).

✍️ Today I've assessed the current situation, moved on from my initial project and looked at TUI crates. I've eventually settled with Ratatui which is a high level version of Crossterm. I've just read the docs today and implemented a barebones TUI. My goal for this week (also outside of the ILA) is to create the TUI with mock data so I can start to implement the actual thing next week.

Screenshot basic layout
<img width="1902" height="1017" alt="image" src="https://github.com/user-attachments/assets/1b0f4a56-bed7-49a9-bb7b-bf19382d57ea" />

## 19.09

- [X] I want the user to see a Spaces & Rooms panel
- [X] I want the user to see a messages panel
- [X] I want the user to be able to navigate between the different panels.

✍️ Today I was able to use the example code strucute and logic for user inputs from the Ratatui documentation and implemented input in the same way. You can now naviate between the rooms with arrow keys and enter messages.
I think I have the basic functions now that the TUI needs so I think I can advance to implementing the actual protocol which will take some time. Next week I want to focus on understanding Matrix itself better and how everything works so I run into less problems in the future. 

[repo](https://github.com/reazndeb/zhongxin)


## 26.09
Understand the Matrix Protocol & think about implemenation structure
