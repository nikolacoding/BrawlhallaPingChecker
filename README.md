# BrawlhallaPingChecker
A simple application that contains several tools for checking and analyzing Brawlhalla ping and ping patterns. Written entirely in C# using Windows Forms and the .NET framework. 
- Form1.cs is the main file in terms of code I've written. Everything else is straight from the framework.

> [!WARNING]
> Warning about general functionality after a revision in 2024:
> 1) The application pings an address/domain provided by Brawlhalla developers, which is hard-coded here. Should the domain name change, or should the public access to it be limited or in any way altered, the app may stop working outright.
> 2) The way pinging the addresses is being handled is unreliable at best. It's been rushed and as a result will most likely yield unrealistic results, most notably about potential packet loss. The behavior upon both sending packets and receiving a response is hardly defined and left up in the air for built-in methods to handle.
> 3) The approach itself is unreliable even if the potential execution issues underlined in the previous point aren't a factor, since the way sending packets has been coded doesn't provide enough repetition and a big enough sample size, hence "smaller" loss percentages (5-7% or so) may not get registered. While this seems so small to the point it's irrelevant, in an actual in-game scenario a loss of even 2% or 3% may render the game nearly entirely unplayable online, and these small margins were the point of the app to begin with.

### - Nikola Marković, ETŠ (October 2021)
