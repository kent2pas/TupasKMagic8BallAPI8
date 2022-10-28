//Kent Tupas
//10/27/2022
//Magic 8 Ball API
//Peer Review: the code runs good. The inputs work. And the code spits 
//Out what it is meant t0. The code looks correct. This program is all good.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TupasKMagic8BallAPI8.Controllers;

[ApiController]
[Route("[controller]")]
public class Magic8BallController : ControllerBase
{
    [HttpGet]
    [Route ("play")]
    public string Magic8BallGame()
    {
        Random rnd = new Random();
        string[] spins = {"Yes Definitely", "Ask Again Later", "Don't Count On It", "Better Not Tell You Now", "Outlook Not So Good", "Signs Point To Yes", "Most Likely", "Very Doubtful", "You May Rely On It"};
        return spins[rnd.Next(spins.Length)];
    }
}