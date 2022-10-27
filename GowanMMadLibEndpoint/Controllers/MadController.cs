/*Madeline Gowan
10-26-2022
Mad Lib - Endpoint
We must create a Mad Lib assignment, but now it must be able to run in Postman, by utilizing the URL

Peer review: Manuel L, I like how there was a cheat sheet inputed so the user wouldnt have to type everything out, overall the code looks really great and works really good as well, great job the the assignment :)
*/

using Microsoft.AspNetCore.Mvc;

namespace GowanMMadLibEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class MadController : ControllerBase
{
//cheat sheet: https://localhost:xxxx/Mad/Info
    [HttpGet]
    [Route("Info")]
public string Info(){
    return "Hello! In this program, you will enter various words, and then they'll be filled into a pre-written story base.\n This way, I'm the one doing all the work :| \n ANYWAYS, the words you will be entering are... \n A place, an adjective, an animal, a verb ending in -ing, a person, a verb ending in -ed, a noise, a person, an object, and a verb ending in -ing.\n (That's 10 different inputs!) \n Good luck!";
}



//cheat sheet: https://localhost:xxxx/Mad/Input/1/2/3/4/5/6/7/8/9/10
   [HttpGet]
   [Route("Input/{place1}/{adjective2}/{animal3}/{verbing4}/{person5}/{verbed6}/{noise7}/{person8}/{object9}/{verbing10}")]
public string Input(string place1, string adjective2, string animal3, string verbing4, string person5, string verbed6, string noise7, string person8, string object9, string verbing10){
    return $"Once in a place called {place1} there was a/n {adjective2} {animal3}. They were {verbing4} around, when suddenly, {person5} blocked the way. The little guy {verbed6} at them, and in response they only heard a {noise7}. So they turned around, intending to leave. But behind them, they found {person8}. They were surrounded. Suddenly everyone simultaneously whipped out a/n {object9}. It was a stand off. This little guy was clearly not going down without a fight. After a tense moment, the people retreated, and satisfied with their victory, the creature spent the rest of its evening {verbing10}.";
}

}

