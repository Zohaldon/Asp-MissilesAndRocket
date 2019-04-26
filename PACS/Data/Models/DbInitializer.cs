using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PACS.Data.Models
{
    public class DbInitializer
    {
        public static void Seed(IServiceProvider applicationBuilder)
        {
            AppDbContext context =
                applicationBuilder.GetRequiredService<AppDbContext>();

            if (!context.Categories.Any())
            {
                context.Categories.AddRange(Categories.Select(c => c.Value));
            }

            if (!context.Rockets.Any())
            {
                context.AddRange
                (
                    new Rocket
                    {
                        Name = "Space Shuttle",
                        Price = 450000000M,
                        ShortDescription = "a reusable launch vehicle to carry astronauts and cargo into space and back again.",
                        LongDescription = "The United States created the Space Shuttle.It is made from three parts—a winged ORBITER, an external fuel tank, and two solid rocket boosters (SRBs).The space shuttle launches like a rocket and lands like a glider. It carries people and cargo into space.",
                        Category = Categories["Liquid-Fueled"],
                        ImageUrl = "../../Images/Liquid-Fueled09_L.jpg",
                        InStock = 3,
                        IsPreferredRocket = true,
                        ImageThumbnailUrl = "../../Images/sst.jpg"
                    },
                    new Rocket
                    {
                        Name = "Falcon Heavy",
                        Price = 90000000M,
                        ShortDescription = " A reusable heavy-lift launch vehicle designed and manufactured by SpaceX.",
                        LongDescription = "Falcon Heavy is the most powerful operational rocket in the world by a factor of two. With the ability to lift into orbit nearly 64 metric tons (141,000 lb)---a mass greater than a 737 jetliner loaded with passengers, crew, luggage and fuel--Falcon Heavy can lift more than twice the payload of the next closest operational vehicle, the Delta IV Heavy, at one-third the cost. Falcon Heavy draws upon the proven heritage and reliability of Falcon 9.",
                        Category = Categories["Liquid-Fueled"],
                        ImageUrl = "../../Images/TShirt01_L.jpg",
                        InStock = 10,
                        IsPreferredRocket = true,
                        ImageThumbnailUrl = "../../Images/fht.jpg"
                    },
                    new Rocket
                    {
                        Name = "Titan-Centaur",
                        Price = 432000000M,
                        ShortDescription = " Glenn perfected Centaur rocket with more than 100 launches.",
                        LongDescription = "The Titan IIIE or Titan 3E, also known as the Titan III-Centaur, was an American expendable launch system. Centaur is a two-stage rocket.",
                        Category = Categories["Liquid-Fueled"],
                        ImageUrl = "../../Images/TShirt01_L.jpg",
                        InStock = 2,
                        IsPreferredRocket = false,
                        ImageThumbnailUrl = "../../Images/titant.jpg"
                    },
                    new Rocket
                    {
                        Name = "Vega",
                        Price = 37000000M,
                        ShortDescription = "A launch vehicle for small- to medium-sized satellite payloads",
                        LongDescription = "Vega, is an expendable launch system in use by Arianespace jointly developed by the Italian Space Agency and the European Space Agency.The rocket consisted of three booster stages burning liquid propellant and an liquid-propellant forth stage known as Attitude and Vernier Upper Module or AVUM",
                        Category = Categories["Soild-Fueled"],
                        ImageUrl = "../../Images/TShirt01_L.jpg",
                        InStock = 8,
                        IsPreferredRocket = false,
                        ImageThumbnailUrl = "../../Images/vegat.jpg"
                    },
                    new Rocket
                    {
                        Name = "Shavit",
                        Price = 37000000M,
                        ShortDescription = "Shavit is a small three-stage solid-fueled rocket.",
                        LongDescription = "Shavit (\"Comet\") is an Israeli orbital launch vehicle capable of carrying small satellites into low earth orbit.Shavit consists of three solid fuel motor stages topped by an optional liquid fuel fourth stage. Payloads of only 250-300 kg are possible due to the fact that the rocket must launch toward the west across the Mediterranean Sea, toward the Straits of Gibralter, from Palmachim Airbase on Israel's coast.  The resulting westward, or retrograde orbit, reduces payload mass compared to an eastward launch that would gain free velocity from the Earth's rotation.",
                        Category = Categories["Soild-Fueled"],
                        ImageUrl = "../../Images/TShirt01_L.jpg",
                        InStock = 5,
                        IsPreferredRocket = false,
                        ImageThumbnailUrl = "../../Images/shavitt.jpg"
                    },
                    new Rocket
                    {
                        Name = "Saturn V",
                        Price = 185000000M,
                        ShortDescription = "How about a Journey to the Moon?",
                        LongDescription = "The three-stage liquid-fueled super heavy-lift launch vehicle was developed to support the Apollo program for human exploration of the Moon and was later used to launch Skylab. NASA's incredible Saturn V rocket propelled dozens of humans toward Earth's moon.",
                        Category = Categories["Liquid-Fueled"],
                        ImageUrl = "../../Images/TShirt01_L.jpg",
                        InStock = 7,
                        IsPreferredRocket = true,
                        ImageThumbnailUrl = "../../Images/svt.jpg"
                    },
                    new Rocket
                    {
                        Name = "Delta 3",
                        Price = 350000000M,
                        ShortDescription = "The Delta III rocket is an expendable launch vehicle made by Boeing.",
                        LongDescription = "Aeroplane Manufacturing industry Boieng took a look inside AeroSpace Industry.Of its three flights, the first two were failures, and the third, though declared successful, reached the low end of its targeted orbit range and carried only a dummy (inert) payload.",
                        Category = Categories["Liquid-Fueled"],
                        ImageUrl = "../../Images/TShirt01_L.jpg",
                        InStock = 7,
                        IsPreferredRocket = false,
                        ImageThumbnailUrl = "../../Images/d3t.jpg"
                    },
                    new Rocket
                    {
                        Name = "Delta IV",
                        Price = 400000000M,
                        ShortDescription = "An expendable launch system in the Delta rocket family.",
                        LongDescription = "The Delta IV is a new model of rocket from Boeing. The vehicle is capable of carrying single or multiple payloads weighing between 9,480 to 28,620 pounds. Once in space, the Delta IV can place spacecraft in polar, sun-synchronous, geosynchronous, geosynchronous transfer and low-Earth orbits.",
                        Category = Categories["Liquid-Fueled"],
                        ImageUrl = "../../Images/TShirt01_L.jpg",
                        InStock = 7,
                        IsPreferredRocket = false,
                        ImageThumbnailUrl = "../../Images/DeltaIVt.jpg"
                    },
                    new Rocket
                    {
                        Name = "Minotaur V",
                        Price = 55000000M,
                        ShortDescription = "An American expendable launch system derived from the Minotaur IV.",
                        LongDescription = "The Minotaur V concept leverages Orbital's flight proven heritage of the Minotaur family of launch vehicles to create a low-risk, readily-developed system.It was developed by Orbital Sciences Corporation, and made its maiden flight on 7 September 2013 carrying the Lunar Atmosphere and Dust Environment Explorer spacecraft for NASA",
                        Category = Categories["Soild-Fueled"],
                        ImageUrl = "../../Images/TShirt01_L.jpg",
                        InStock = 5,
                        IsPreferredRocket = false,
                        ImageThumbnailUrl = "../../Images/minot.jpg"
                    },
                    new Rocket
                    {
                        Name = "M-V",
                        Price = 17451000M,
                        ShortDescription = "A Japanese solid-fuel rocket designed to launch scientific satellites.",
                        LongDescription = "M-V was a member of the Mu family of rockets. The Institute of Space and Astronautical Science began developing the M-V in 1990 at a cost of 15 billion yen.",
                        Category = Categories["Soild-Fueled"],
                        ImageUrl = "../../Images/TShirt01_L.jpg",
                        InStock = 6,
                        IsPreferredRocket = false,
                        ImageThumbnailUrl = "../../Images/mvt.jpg"
                    },
                    new Rocket
                    {
                        Name = "Epsilon 3",
                        Price = 38000000M,
                        ShortDescription = "A Japanese solid-fuel rocket for cargo.",
                        LongDescription = "Epsilon rockets are launched from a pad at the Uchinoura Space Center previously used by Mu rockets. ",
                        Category = Categories["Soild-Fueled"],
                        ImageUrl = "../../Images/TShirt01_L.jpg",
                        InStock = 12,
                        IsPreferredRocket = false,
                        ImageThumbnailUrl = "../../Images/ept.jpg"
                    },
                    new Rocket
                    {
                        Name = "GSLV Mark 3",
                        Price = 46000000M,
                        ShortDescription = "The Geosynchronous Satellite Launch Vehicle Mark III",
                        LongDescription = "GSLV Mk III is a three-stage heavy lift launch vehicle developed by ISRO. ... The two strap-on motors of GSLV Mk III are located on either side of its core liquid booster. ... The first developmental flight of GSLV Mk III, the GSLV-Mk III-D1 successfully placed GSAT-19 satellite to a Higher Orbit",
                        Category = Categories["Liquid-Fueled"],
                        ImageUrl = "../../Images/TShirt01_L.jpg",
                        InStock = 12,
                        IsPreferredRocket = false,
                        ImageThumbnailUrl = "../../Images/gslvt.jpg"
                    },
                    new Rocket
                    {
                        Name = "BFR",
                        Price = 102000000M,
                        ShortDescription = "Let's Visit Planet Mars!!",
                        LongDescription = "The Big Falcon Rocket (officially shortened to BFR) is a privately funded fully reusable launch vehicle and spacecraft system in development by SpaceX. The overall space vehicle architecture includes both launch vehicles and spacecraft, as well as ground infrastructure for rapid launch and relaunch, and zero-gravity propellant transfer technology to be deployed in low Earth orbit (LEO). The payload capacity to Earth orbit of at least 100,000 kg (220,000 lb) makes BFR a super heavy-lift launch vehicle. The first orbital flight is tentatively planned for 2020.",
                        Category = Categories["Liquid-Fueled"],
                        ImageUrl = "../../Images/TShirt01_L.jpg",
                        InStock = 3,
                        IsPreferredRocket = true,
                        ImageThumbnailUrl = "../../Images/bfrt.jpg"
                    },
                    new Rocket
                    {
                        Name = "PSLV",
                        Price = 62000000M,
                        ShortDescription = "The Polar Satellite Launch Vehicle (PSLV).",
                        LongDescription = "Polar Satellite Launch Vehicle (PSLV) is the third generation launch vehicle of India. It is the first Indian launch vehicle to be equipped with liquid stages. After its first successful launch in October 1994, PSLV emerged as the reliable and versatile workhorse launch vehicle of India with 39 consecutively successful missions by June 2017. During 1994-2017 period, the vehicle has launched 48 Indian satellites and 209 satellites for customers from abroad.",
                        Category = Categories["Soild-Fueled"],
                        ImageUrl = "../../Images/TShirt01_L.jpg",
                        InStock = 1,
                        IsPreferredRocket = true,
                        ImageThumbnailUrl = "../../Images/pslvt.jpg"
                    }
                );
            }
            context.SaveChanges();
        }

        private static Dictionary<string, Category> categories;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (categories == null)
                {
                    var genresList = new Category[]
                    {
                        new Category { CategoryName = "Soild-Fueled", Description = "A solid-propellant rocket with a rocket engine that uses solid propellants (fuel/oxidizer)." },
                    new Category { CategoryName = "Liquid-Fueled", Description = "A liquid-propellant rocket with a rocket engine that uses liquid propellants." }
                    };

                    categories = new Dictionary<string, Category>();

                    foreach (Category genre in genresList)
                    {
                        categories.Add(genre.CategoryName, genre);
                    }
                }
                return categories;
            }
        }
    }
}
