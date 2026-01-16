# Reverse engineering my mouse's screen
I have this gloriously ergonomic mouse from China that came with a small OLED display - currently a display of shear wasted potential. Sure, it shows DPI settings and battery percentage, things that are _technically_ useful if you're the kind of person who enjoys knowing when your mouse is about to die. But let's be honest: who actually needs that when you could have a tiny screen cycling through cat gifs instead?

The problem? It's a cheap Aliexpress mouse with firmware more locked down than a nuclear bunker. I already know these little OLED screens pretty well from an abandoned custom keyboard project (RIP, you would have been beautiful but 3D CNC stuff is too hard and too expensive). They're stupidly simple to control - assuming you have an Arduino and aren't trapped behind proprietary Windows-only drivers that laugh at your dreams of customization in Chinese.

However, this is totally doable. I already took a halfhearted look at it a few months ago, which mostly consisted of asking ChatGPT and then immediately abandoning ship because life got in the way. But now? Now I have about 10 hours of ILA time which is not enough to master some shiny new framework, but exactly the right amount to dive into something I've never tried before: low-level firmware tinkering and reverse engineering also I'll finally get my revenge (_hopefully_)

Plus, it'd make for a killer blog post, which is ideal because I've been itching to write more and actually put stuff on my website. Last time I tried starting a blog, it died after exactly one post ([see Blog post - about 8min read about Dajia](https://reazn.tech/#dajia-popup)).

First step: Open up the mouse and see what hardware it uses.


---

I havent done anything for this project in the first ILA session but I've continued to work on our IDPA project Purbank and continued where we left of last LP. We'll finish our project next week so I can start working on it next week. Also I would work on this outside of ILA.


### Stuff I learned

### key rollover 
One device has multiple HID interfaces so multiple simultaneous keypresses are possible (see screenshot)

<img width="1106" height="306" alt="image" src="https://github.com/user-attachments/assets/bc12d2eb-44f7-4658-8d8f-2d16911951c8" />

### This is how the moues looks dissected

<img width="1174" height="1516" alt="image" src="https://github.com/user-attachments/assets/0958dab8-0670-4645-833e-f3d7db44beaa" />

I was able to find my mice's processors and sensors datasheet but sadly I wasnt able to find the datasheet of the display processor (both are uploaded in this repo)

---

WIP will change in bus

I have to work with a separate arduino/micro chip now so that I can overwrite the payloads the main processor sends to the screen as its SoC (system on chip - payloads for image are not in hexdumps - HID)

I will now try to contact Mr Lauk since he studied micro electronics to ask for help, I've often seen him in Bausteln so I think he'd be pleased to help
