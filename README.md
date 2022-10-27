# GowanMMadLibEndpoint
Madeline Gowan
10-26-2022
Mad Lib - Endpoint
We must create a Mad Lib assignment, but now it must be able to run in Postman, by utilizing the URL

Peer review: Manuel L, I like how there was a cheat sheet inputed so the user wouldnt have to type everything out, overall the code looks really great and works really good as well, great job the the assignment :)

INSTRUCTIONS
Before anything, open the code in VSCode and run/debug the code. This should lead to a new tab opening, labelled localhost. Copy and paste the URL from that new tab, into the Postman "GET" area. Then, add to the end of the URL like this:
https://localhost:xxxx/Mad/Info
The xxxx should be the 4-digit number individual to your computer. Then you will have /Mad/Info. Then hit "Send". Text should appear explaining what a madlib is, and what answers you should be providing. Afterwards, replace the URL with:
https://localhost:xxxx/Mad/Input/1/2/3/4/5/6/7/8/9/10
Aka, replace /Info with /Input. You will then enter your answers for each of the prompted words to be entered, that were listed in /Info. These words will go into the spots I've labelled with numbers in the order provided in /Info. When you are done, hit "Send" again. You should see a story, filled out with your entered terms.
