# Project idea
A customisable profile card website showcasing one's LastFM activity and various links. 

### Frontend:
↳ Landing <br>
↳ Profile <br>
↳ Dashboard / Settings

I'm using React (jsx) in combination plain CSS for the frontend.

**Profile Showcase** <br>
![sneakpeek2-ezgif com-optimize](https://github.com/user-attachments/assets/8aabc094-4021-454b-b484-ab2ab5306264) <br>
 <br><br>
**Settings Showcase** <br>
Customise <br>
<img src="https://github.com/user-attachments/assets/ad1cf7a0-53ac-4ee0-84bf-49def084d565" width="1000" /> <br>
<img src="https://github.com/user-attachments/assets/314e9215-b9c6-48aa-9868-fc3ca77a1e88" width="1000" /> <br>

Links <br>
<img src="https://github.com/user-attachments/assets/a93405b9-bdd6-49f7-ae5b-ced07682a2db" width="1000" /> <br>

Cards <br>
<img src="https://github.com/user-attachments/assets/ae7ff918-0b1a-470f-91db-f113950db0f3" width="1000" /> <br>



In the settings you can customise pretty much everything:
1. colors for virtually everything
2. profile / background picture
3. bio text
4. effects for the text (typewriter, glow)
5. various opacities
6. links
7. Font type
8. Font color (for headers, text, subtext)
9. custom cursors
10. cursor trails
11. custom audios
12. custom boxes (embed of link with extra information such as Github followers or Youtube followers, amount videos & description)
13. ...

### Backend

The page is mainly static and doesn't require as server, yet it still needs a backend for the API. Currently I'm retrieving information about the user's Discord activity through a Discord bot written in JavaScript using Discord.JS. 
The website is currently fetching the LastFM data each time the users profile is loaded which is not good rate limt wise (using the Spotify API for covers which is even more limited request wise). That's why when I want to launch the website I need to fetch each users LastFM data and store it in the Database. For this I want to use Rust as I'm currently learning it and I think I'm now on a level where I can try to use it in this project. If I succeed in that then I'll rewrite the Discord bot in Rust so everything uses the same programming language and as overal training. 

**Database showcase** <br>
For the Database I'm using Supabase as it's easy to set up and it has CDN which makes everything much faster when using the website from around the world in comparision to hosting the database locally on my Raspberry-Pi. 

<img src="https://github.com/user-attachments/assets/ce9e99ce-8dda-41db-89f1-b91df0ebdfd1">

On the left side are the tables that contain text, links, images (buckets) etc. 
On the right side are tables that store data about the styling, for example color, font, opacity etc.

## Make or break features
1. Profile page MUST load fast
2. Settings should be clear and the user should have a good experience while creating his profile
3. LastFM features work all the time (no missing covers => API limits)

## Check progress
> Check issues & milestones [here](https://github.com/Dajialol/dajia.lol)

Eventually I'll move the backend (Discord bot & API fetching) into its own repository but currently everything is in this one repository)


---

## April 25

Save users LastFM data in DB (instead of fetching everytime when the users profile is opened = causes Spotify API ratelimits)
- [X] write documentation about current progress, explain frontend, backend, DB etc
- [X] create DB tables for the LastFM Data 
- [X] look at how to use APIs in Rust (reqwest, tokio etc) - Don't think I can fully implement it in 45min.

✍️Today I wrote the documentation about where I currently am regarding my project as well as a detailed explanation of the project itself and how I'm implementing it. I also created the tables that I'll need to store the API data later on. I added the current playing song to the profile_lastfm as well as a top artist, top track and top album table. For each of those tables I have a column for each section of the API response that LastFM provides along with a column for the time range. I also looked inot how to implement an API in Rust, which I didn't really know how to do before, I just knew I had to use tokio, serde and reqwest. I also added the Supabase connection so when the Rust project is run the current playing song is saved in the profile_lastfm table. 

The code for the Rust backend is [here](https://github.com/Dajialol/lastfm). <br><br>

<br>

## May 2
- [ ] Save 'Top ...' in DB (every hour)
- [ ] Save 55 most recent songs in extra table (not created yet)
- [ ] Update 'Top ... ' if current playing song is somewhere in there (could use hashmap => figure out if that's possible to do while the data is in the DB => how)

Device less
- [ ] Look at DB structure, what is unclear, is it worth cleaning up? 

<br> <br> 

notes, ignore <br>
> _updates everytime when a new song is played, => update recent plays & use hashmap for top tracks/albums/artist, check if current playing song/album/artist is in hashmap => update hashmap's play count after the half way point of the song (same logic as Spotify = 50% needs to be played to > count as a play). As a backup I'll fetch the stats of the user (top artist/album/track etc) once each day / each hour depending on how much performance it takes._ <br><br>
> 
> **In DB add table for:** <br>
> 1. Recent plays _(55 items, while only 50 are showing in the profile I think it's smart to have an small excess just in case, depending on how the loading times are I can increase this to 100 tracks)_
> 2. Top tracks _(column for timeframe)_
> 3. Top album _(column for timeframe)_
>4. Top artist _(column for timeframe)_

