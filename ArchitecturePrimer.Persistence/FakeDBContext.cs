using System;
using System.Collections.Generic;
using ArchitecturePrimer.Domain;
using System.Threading;

namespace ArchitecturePrimer.Persistence
{
    public class FakeDbContext : IDbContext
    {
        public HomeModel GetHomeData()
        {
            //Fake Delay
            Thread.Sleep(500);
            return new HomeModel()
            {
                Title = "Tile for the Home Page",
                Description = "Lorem ipsum dolor sit amet, quis alii ei mea. Dicat sententiae definiebas has ut, id has nostro viderer,.",
                HeroText = "Hero title"
            };
        }

        public List<HomeFeatureModel> GetHomeFeaturesData()
        {
            //Fake Delay
            Thread.Sleep(250);
            var features = new List<HomeFeatureModel>()
            {
                new HomeFeatureModel()
                {
                    Title = "Pri solum doctus ex",
                    Description = "Lorem ipsum dolor sit amet, quis alii ei mea. Dicat sententiae definiebas has ut, id has nostro viderer, est ad dicat veniam senserit. Sea denique consulatu consectetuer ad. No usu corpora principes gloriatur, in graeco accommodare eos. Vis ad dolore scriptorem, mei exerci utamur in, an vis labore fierent at.",
                    Link = "https://google.com",
                    LinkText =  "More",
                    PostedDate = new DateTime(2019,10,26,10,34,32)
                },
                new HomeFeatureModel()
                {
                    Title = "Eos an bonorum",
                    Description = "Lorem ipsum dolor sit amet, cu falli fabulas eam. Eius veritus constituto ut sit, nonumy menandri maluisset mei in. Ei adipisci nominati principes vix, ex eum appareat tincidunt. Ea nec scripta recteque repudiare. Duo odio scripta pertinax ne. Vitae graecis vel an, et pro graeco omittam recteque, vis cu tantas.",
                    Link = "https://ceridian.com",
                    LinkText =  "Learn",
                    PostedDate = new DateTime(2019,10,28,11,32,54)
                },
                new HomeFeatureModel()
                {
                    Title = "His hinc interpretaris",
                    Description = "Lorem ipsum dolor sit amet, id vis tale tractatos honestatis. Ex duo sanctus apeirian mediocritatem, pro noster honestatis id, eu exerci utamur docendi eum. Mea enim volutpat no, at postea torquatos vis. In vis nihil legimus nonumes, deleniti accusamus ex usu. Est nihil equidem sapientem te, duo ceteros persec.",
                    Link = "https://amazon.com",
                    LinkText =  "Go",
                    PostedDate = new DateTime(2019,10,28,13,12,22)
                }
    };

            return features;
        }
    }
}