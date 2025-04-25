For the past two months I've been working on a [website project](https://dajia.lol) using React and various APIs which I technically already completed. 

However I still have to make some performance improvements, especially for the fetching functions and how I use the Database. 

I also have to think about how I should host the website, my current options are either localhosting on my Raspberry Pi which would run into performance issues rather quick. 
The other Option I've considered was Github pages as it works well with React and I can still host my backend locally. 
I've yet to look into the Cloudflare / Heroku path (via Github Students I have 20CHF monthly credits on Heroku). 
However I think Github pages is the most stable and easiest solution available.

The project I want to work on after I finish this is going to be Rust related as I've been learning Rust for a month now and want to create something with it that has an actual usecase. 

# April 25

Save users LastFM data in DB (instead of fetching everytime when the users profile is opened = causes Spotify API ratelimits) 
  - [ ] create DB tables for the LastFM Data 
  - [ ] implement the fetching part on the backend

updates everytime when a new song is played, => update recent plays & create Hashmap for top tracks/albums/artist, check if current playing song/album/artist is in Hashmap => update Hashmap play count after the half way point of the song

_Trying to implement the LastFM backend in Rust, in the future I'll have to rewrite the Discord Backend which is currently in JS (using Discord.JS) so everything is uniform and easier to maintain._
