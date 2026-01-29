# Reverse engineering my mouse's screen
I have this gloriously ergonomic mouse from China that came with a small OLED display - currently a display of shear wasted potential. Sure, it shows DPI settings and battery percentage, things that are _technically_ useful if you're the kind of person who enjoys knowing when your mouse is about to die. But let's be honest: who actually needs that when you could have a tiny screen cycling through cat gifs instead?

The problem? It's a cheap Aliexpress mouse with firmware more locked down than a nuclear bunker. I already know these little OLED screens pretty well from an abandoned custom keyboard project (RIP, you would have been beautiful but 3D CNC stuff is too hard and too expensive). They're stupidly simple to control - assuming you have an Arduino and aren't trapped behind proprietary Windows-only drivers that laugh at your dreams of customization in Chinese.

However, this is totally doable. I already took a halfhearted look at it a few months ago, which mostly consisted of asking ChatGPT and then immediately abandoning ship because life got in the way. But now? Now I have about 10 hours of ILA time which is not enough to master some shiny new framework, but exactly the right amount to dive into something I've never tried before: low-level firmware tinkering and reverse engineering also I'll finally get my revenge (_hopefully_)

Plus, it'd make for a killer blog post, which is ideal because I've been itching to write more and actually put stuff on my website. Last time I tried starting a blog, it died after exactly one post ([see Blog post - about 8min read about Dajia](https://reazn.tech/#dajia-popup)).

---

### 16.01.2026

Today I experimented with the HID, I intercepted the signal and looked through it, I was able to see how the communication between the mouse and the operating system works however I wasnt able to find any information about the screen in the hexdumps of the HID - this makes me believe that the screen is processed entirely on the mouse without (SoC). I also opened up the mouse and was able to find datasheets for both the processor and the sensor however I wasnt able to find one for the display processor which I believe is at the bottom right. I even tried to find one on Baidu.cn (the chinese google) but couldnt find one. Now my projects diverts a bit from regular programming as my only option is to attach an Arduino and just control the screen with that. I dont know if this is still within the bounds of ILA, to stay within bounds I think I will try to learn more about HID and how hardware interacts with operating systems (especially Linux) and write a small report of what I learned at the end which will focus on explaining said topic with the helps of visualisations.

### Stuff I learned

### key rollover 
One device has multiple HID interfaces so multiple simultaneous keypresses are possible (see screenshot)

<img width="1106" height="306" alt="image" src="https://github.com/user-attachments/assets/bc12d2eb-44f7-4658-8d8f-2d16911951c8" />

### This is how the moues looks dissected

<img width="1174" height="1516" alt="image" src="https://github.com/user-attachments/assets/0958dab8-0670-4645-833e-f3d7db44beaa" />

I was able to find my mice's processors and sensors datasheet but sadly I wasnt able to find the datasheet of the display processor (both are uploaded in this repo)

### 23.01.2026
- [X] explore HID communication
- [X] send custom payloads to see how it works
- [X] summarize my new found knowledge

Today I spent most of my time trying to send custom HID payloads to my mouse to see if I could somehow trigger the screen controller. I used hidapitester to poke around and send different commands, but the mouse basically ignored everything that wasn't a standard HID request like DPI changes. The screen seems to be completely isolated from the HID interface, which confirms what I suspected earlier.
After trying various report IDs and byte patterns with no success, I had to accept that the only real way forward would be to physically intercept the display's communication lines with a small Arduino. I'd need a 3.3V Pro Micro or something similar that could fit inside the mouse housing and tap into the I2C or SPI bus that connects the main processor to the display chip.
I looked into ordering one but realized it wouldn't arrive in time for my this week. It's frustrating because the solution is technically straightforward - just intercept and inject custom data into the display bus - but I'm blocked by shipping times and the fact that I waited too long to try this approach.
So instead of getting my cat gifs, I'm pivoting to documenting what I learned about HID communication and how devices isolate their internal components from external control.
