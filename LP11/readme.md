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

### Challenges I might (and will) face
- Enter executes an app (closes the launcher) but I need the enter input to send out the prompt to Ollama
- Error: Time out exceeded -> if nothing happens (AI requests takes a bit based on the PC) Sherlock will time it out and automatically cancell the request
- Formatting (Sherlock height is fixed so I'll probably have to add 'system prompts'? if not to exceed a certain length so it can be shown nicely.
- Copy response (is theoretically possible but unsure how as of now) -> copy specific part of response instead of everything -> maybe split each paragraph
- Speed of Ollama
- Other Ollama related issues like need to execute `Ollama serve` at system start to even start Ollama, not sure if this can be automated by Rust or if this is even wished for since it'd change daemon settings -> needs sudo -> people might be unhappy with that
