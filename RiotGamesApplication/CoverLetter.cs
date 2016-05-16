using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace RiotGamesApplication
{
    class CoverLetter
    {
        
        public string Greeting
        {
            get
            {
                return "Hello Mel Capperino,";
            }
        }
        public string[] Body
        {
            get 
            {
                return new string[] {
                    @"About 9 years ago, I worked on a little open source project using LUA and I was captivated.
                I couldn’t pull myself away from programming. I knew at that moment that this is what I wanted to 
                do for the rest of my life. Since then, I programmed and worked on multiple advanced Minecraft 
                plugins and was the lead developer on multiple well-known servers and networks, who still ask for
                my help to this day. I enjoyed every moment I spent programming and building a gratifying experience
                for hundreds of thousands of people out of creativity, ambition, and hard-work. Programming isn’t 
                just a job for me, it’s a passion. ",

                    @"I’m heavily dedicated to my job and have spent countless amount of volunteered hours dedicated
                to solving issues. I know from personal experience that everyone wants a smooth and easy transition 
                in anything they’re doing. I know I can provide that. ",

                    @"I love making people happy. I spend so much of my time invested in making people happy both
                professionally, and in my everyday life, that it has integrated itself as one of my needs. I have an
                overwhelming desire to put a smile on every face I encounter, because everyone deserves the best 
                quality of life. No excuses.",

                    @"I started playing League of Legends back in season 2. Ever since then, I’ve spent a lot of time 
                thinking on what I could do to improve this game. I think that I can help alleviate the new player 
                experience by pitching, creating, and demonstrating creative ideas that hopefully, you’ll very much 
                enjoy. It was a pleasure speaking to you at PAX and I'm excited about the opportunity to speak with
                you again."
                };
            }
        }

        public string Farewell
        {
            get
            {
                return "Kindest regards, Matt Sutton";
            }
        }
        public string riv_quote
        {
            get
            {
                return "You never have to work a day in your life if you do something you love. I will be buried with a microphone! - Rivington III";
            }
        }
        public string c_sharp_only_message
        {
            get
            {
                return "This cover letter was generated using entirely C#. I did not write this in Word. Check out github.com/sheepiiHD for the source code.";
            }
        }
        
    }
}
