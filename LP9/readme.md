# Learning Period 9

February 21 to April 4

## Rough Planning

1. Which projects do you already have on your GitHub that you could link to?
   <br>
    _=> Flagtactoe website, habenwirmorgenopl.info, note-taking website with markdown implementation, schulnetz calculate average grade Chrome extension_ <br> <br>
2. What does your *skill portfolio* look like? What can you already do, and what would you like to learn?
   <br> 
     _=> C#, , HTML, CSS, JavaScript, a little Python, a little React_ <br> <br>
3. What would be a good project for the second half of this learning period?
   <br> 
   _=> Music tracker website with LastFM API, ChartJS for charts, JS as backend, Discord bot using Python._

## February 21

- [X] Create a basic structure for my homepage. This should include a hook sentence, contact information, a link to my CV, and highlight some projects.
  - [X] Designed an appealing layout for the homepage on paper, along with a "hook sentence" to capture the attention of potential employers.
  - [X] Implemented this layout in a rudimentary way using HTML and CSS.

- [x] Online presence: If a potential employer searches for my name on a search engine, only professional information should appear, if anything.
- [x] Fill out a reference letter:
  - [x] Write down some key characteristics that define me.
  - [ ] Find and articulate evidence for these characteristics.
  - [x] Spell check.

✍️ Today I sketched the rough plan on paper, including some subpages. I also wrote the reference letter.

## February 28

- [ ] Compile my CV.
- [x] Create/clean up LinkedIn profile.
- [x] Professionalize GitHub profile (`readme.md`).
- [ ] Implement LastFM integration.

✍️ Today I worked on the LastFM integration. The homepage now displays my most recently played song and my top artist/album/song of the past month. Since I listen to a lot of music and have previously worked with ChartJS and the LastFM API, I thought this would be a great way to personalize the website.

☝️ Don't forget to upload the updated version of your homepage to the designated folder.

## March 7

- [x] Copy the projects section from my old portfolio website.
- [x] Format the projects section to fit the new website.
- [x] Create a CV page.
- [x] Add more content to the About Me section.
- [x] Provide feedback.

✍️ Today I copied the portfolio section from my old portfolio into the new one and adjusted the styles accordingly. I also fixed the LastFM integration. Since my website is hosted on Heroku, the file hosting works differently than locally. Everything worked fine on my machine but not on Heroku. (I migrated to local hosting now since with Github Education you're only able to host two free node websites per month and this was my third. Also I hosting it on my own is a great chance to learn basic linux commands and learn how server hosting and maintaining is done.)

I solved the issue today by updating the play data manually instead of running a script every hour. It's not ideal, but better than a non-working integration. An automated solution on Heroku would require storing the data in an external database like SupaBase, but I haven't had time for that yet, and it would complicate the project unnecessarily.

☝️ Don't forget to upload the final version of your homepage to the designated folder.

## March 14

- [x] Fix preview card in the project section to accommodate a redirect arrow on the right side.
- [ ] Add more content to the About Me box (maybe add a portrait, ASCII portrait, or ASCII GIF).
- [x] Create the About Me section (section ≠ box).
- [x] Add a navigation bar on the right side.

✍️ Today I managed to finish all the goals I set for myself. I'm also really proud of the navigation bar on the right side. However I still have some free space in the about-box which I still haven't decided what to do with it so I just left it for now.

## March 21

- [x] Make portfolio responsive for mobile screens.
- [X] Make portfolio responsive for desktop (<1280px horizontal width).
- [X] Set up a Discord bot in the Developer Portal and assign necessary permissions and scopes.
- [X] Add basic economy functions

✍️ Today I made my site responsive, which I usually hate doing, but it actually went quite well for my portfolio. During the second half of the day I started working on a Discord bot for our server together with @seeaky (David Koteski) and @bettercallmilan (Milan Jankovic). I created the bot in the Discord Developer Portal and set up the according permissions and scopes for it.  

_Since I've learned from the last time when I worked together with other people on a project we decided to work with Pull Requests and never commit to the main branch (We had to painfully find out the consequences of commiting to the main branch to come up with that idea.)_


## March 28

- [X] add basic level system (earn xp for messages)
- [X] add lastFM integration (connect discord_id to lastfm_username)
- [X] display current playing song for user 

✍️ Today I added the -lvl and -lvltop commands, each user is now able to level up their. (approx. 500 messages per level) Users are also able to use the -lvltop command to see the current highest leveled users in the server. I also added a LastFM integration so you can now link your LastFM account to our bot using -login [lastFMusername]. Once a user linked both of their accounts they can use -np to display their current playing track! 

### Newly added commands showcase
-lvl <br>

<img src="https://github.com/user-attachments/assets/65f1849f-31a0-4815-8e20-298123bbdb7b" alt="lvl showcase" width = "300"/>


-lvltop <br>

<img src="https://github.com/user-attachments/assets/86b17986-6189-40fb-a6e8-c6f08805a46e" alt="lvltop showcase" width="300"/>

-np <br>
<img src="https://github.com/user-attachments/assets/a4f97bb1-ddb1-40db-be62-ad034ae3226d" alt="now playing showcase" width="300"/>

-me / -p / -profile <br>
<img src="https://github.com/user-attachments/assets/5474cf39-d73a-4287-a4c3-9a332f6d37d4" alt="LastFM profile" width="300"/>


## April 4
- [X] add time in call tracking feature (add time amount to DB/.json)
- [X] output time in call data into embed (-vlvl for oneself and -vtop for server wide voice leaderboard) 
- [X] add lastfm -snp (server now playing) command that shows all the users that are currently listening to a song

✍️ Today I added tracking for the voice chats which took longer than expected, I originally planned to maybe add a chart using a chart library to the output message but I had no time and just continued with the lastfm feature I wanted to add which I successfully did.

=> https://github.com/IM23d/discord-balance-bot

