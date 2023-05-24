using eTickets.Data.Static;
using eTickets.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Data
{
    public class AppDbInitializer
    {
            public static void Seed(IApplicationBuilder applicationBuilder)
            {
                using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
                {
                    {
                        var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                        context.Database.EnsureCreated();

                        //Cinema
                        if (!context.Cinemas.Any())
                        {
                            context.Cinemas.AddRange(new List<Cinema>()
                        {
                            new Cinema()
                            {
                                Name = "Yash Raj Films",
                                Logo = "https://www.yashrajfilms.com/images/default-source/About-YRF---Company-Info/yash-raj-films2a889ba026f56f7f9f64ff0000090313.png",
                                Description = "YRF is one of the most successful production houses in the country. It has made superstars out of everyday dudes. Also, it keeps rolling out a Dhoom movie every once in a while to keep Uday Chopra’s acting career alive"
                            },
                            new Cinema()
                            {
                                Name = "UTV Motion Pictures Ltd",
                                Logo = "https://upload.wikimedia.org/wikipedia/en/a/a6/UTV-Motion_Pictures.jpg",
                                Description = "Founded by Ronnie Screwvala, this production house is currently headed by Siddharth Roy Kapur who was the marketing mind behind Rang De Basanti. This man sure knows how to market his films… and himself (he’s married to Vidya Balan.*sigh*)."
                            },
                            new Cinema()
                            {
                                Name = "Eros International",
                                Logo = "https://www.adgully.com/img/800/201701/erosintl.jpg",
                                Description = "A production house so profitable that it’s listed in the London Stock Exchange and the Bombay Stock Exchange. Well, that’s Eros for you. If you release your film under this banner, chances are that they’ll distribute your film to 50 other nations, courtesy their wide distribution network."
                            },
                            new Cinema()
                            {
                                Name = "Dharma Productions",
                                Logo = "https://upload.wikimedia.org/wikipedia/en/0/02/Dharma_Production_logo.png",
                                Description = "The signature crooning of the lady at the beginning of a Dharma film instantly brings back memories of Kuch Kuch Hota Hai. This production house was set up way back in 1976 by Yash Johar. Of late, Karan Johar has been warming the chairman’s seat (when he’s not in the judge’s seat of India’s Got Talent)."
                            },
                            new Cinema()
                            {
                                Name = "Red Chillies Entertainment",
                                Logo = "https://upload.wikimedia.org/wikipedia/en/2/21/Red_Chillies_Entertainment_logo.png",
                                Description = "We all love SRK and so does SRK, so much so that he gifted himself Red Chillies, a production house that churns out films with only him in the lead (or at least in an item number #Kaal)."
                            },
                            new Cinema()
                            {
                                Name = "Rajshri Productions",
                                Logo = "https://jobs.socialsamosa.com/wp-content/uploads/2018/10/rajshree-logo-sqr.png",
                                Description = "If production houses had brand ambassadors, Alok Nath would have been perfect for Rajshri Productions. Known to make films loaded with sanskaar and sanskriti , this banner has produced classics which every Indian dadaji would want to show his grandchildren. You’ll never have to think twice when you take your grandparents for a Rajshri film."
                            },
                            new Cinema()
                            {
                                Name = "Bhansali Productions",
                                Logo = "https://mir-s3-cdn-cf.behance.net/project_modules/max_1200/8a18743114479.5b0098b758567.jpg",
                                Description = "Sanjay Leela Bhansali creates magic on screen with the awesome sets and costumes. I’m guessing he began producing his own films because then he wouldn’t have to justify the lakhs he plans to spend on those curtains… that would appear for less than 2 seconds in the movie."
                            },
                            new Cinema()
                            {
                                Name = "Balaji Motion Pictures",
                                Logo = "https://upload.wikimedia.org/wikipedia/en/e/e8/Balaji_Motion_Pictures_logo.jpg",
                                Description = "From the small screen to the silver screen, Ekta Kapoor has come a long way. I’m glad she didn’t extend her fascination for the letter ‘K’ to films."
                            },
                            new Cinema()
                            {
                                Name = "Nadiadwala Grandson Entertainment Pvt Ltd",
                                Logo = "https://upload.wikimedia.org/wikipedia/en/f/f6/Nadiadwala_Grandson_Entertainment_logo.jpeg",
                                Description = "The name has “grandson” in it that says it all. The Nadiadwalas have been doling out blockbusters for 3 generations, beginning with the Ashok Kumar-starrer Inspector in 1956 to the recent Salman Khan blockbuster Kick."
                            },
                            new Cinema()
                            {
                                Name = "Reliance Big Entertainment",
                                Logo = "https://upload.wikimedia.org/wikipedia/commons/6/6f/Reliance_Entertainment.png",
                                Description = "From mobiles to petroleum, Reliance has always been all over the place and thus it came as no surprise when they announced their entry into film production in 2005. All their films have tasted success… except for Kites."
                            },
                            new Cinema()
                            {
                                Name = "Aamir Khan Productions",
                                Logo = "https://upload.wikimedia.org/wikipedia/commons/2/22/Aamir_khan_productions.png",
                                Description = "The Perfectionist put everything at stake and set up Aamir Khan Productions in 2000 for Lagaan . The rest as they say is history. Since then, every film coming out of Aamir’s production house has gone on to become a super hit. Some say it’s his perfection, others believe it’s Kiran Rao’s charm that works for him."
                            },
                            new Cinema()
                            {
                                Name = "Excel Entertainment",
                                Logo = "https://upload.wikimedia.org/wikipedia/en/8/8c/Excel_Entertainment_logo.png",
                                Description = "Excel Entertainment excelled on its debut with the release of Dil Chahta Ha i. They’ve been on a roll ever since. Headed by Farhan Akhtar and Ritesh Sidhwani, this banner has an enviable track record."
                            },
                            new Cinema()
                            {
                                Name = "Anurag Kashyap Films Pvt Ltd",
                                Logo = "https://mir-s3-cdn-cf.behance.net/projects/404/7974185.5474d2e65d45c.jpg",
                                Description = "AKFPL, as it is popularly known, was founded in 2006 by the maverick Anurag Kashyap. This banner might not have the money that other biggies have but it sure fosters the courage to give newcomers a chance. AKFPL’s USP is the high-on-content films that it produces."
                            },
                        });
                            context.SaveChanges();
                        }
                        //Actors
                        if (!context.Actors.Any())
                        {
                            context.Actors.AddRange(new List<Actor>()
                        {
                            new Actor()
                            {
                                FullName = "Amir Khan",
                                Bio = "Mohammed Aamir Hussain Khan is an Indian actor, film director and producer who works in Hindi films. Through his career spanning over 30 years, Khan has established himself as one of the most popular and influential actors of Indian cinema.",
                                ProfilePictureURL = "https://img.mensxp.com/media/content/2020/Mar/Bollywood-Blockbusters-Aamir-Khan-Declined-1200x900_5e6cd30229e73.jpeg"

                            },
                            new Actor()
                            {
                                FullName = "Abhishek Bachchan",
                                Bio = "Abhishek Bachchan is an Indian actor and film producer known for his work in Hindi films. Part of the Bachchan family, he is the son of actors Amitabh Bachchan and Jaya Bachchan and the grandson of poet Harivansh Rai Bachchan and social activist Teji Bachchan. ",
                                ProfilePictureURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTy15_crlcCIBpsxlDJ44SuGo71cgZ-4AKLw745Vl1Yyd4WPrHK"
                            },
                            new Actor()
                            {
                                FullName = "Rabir Kapoor",
                                Bio = "Ranbir Kapoor is an Indian actor known for his work in Hindi-language films. He is one of the highest-paid actors of Hindi cinema and has featured in Forbes India's Celebrity 100 list since 2012. Kapoor is the recipient of several awards, including six Filmfare Awards. ",
                                ProfilePictureURL = "https://flxt.tmsimg.com/assets/509114_v9_ba.jpg"
                            },
                            new Actor()
                            {
                                FullName = "Amitabh Bachchan",
                                Bio = "Amitabh Bachchan is an Indian actor, film producer, television host, occasional playback singer and former politician known for his work in Hindi cinema. He is regarded as one of the most influential actors in the history of Indian cinema.",
                                ProfilePictureURL = "https://m.media-amazon.com/images/M/MV5BNTk1OTUxMzIzMV5BMl5BanBnXkFtZTcwMzMxMjI0Nw@@._V1_.jpg"
                            },
                            new Actor()
                            {
                                FullName = "Saif Ali Khan",
                                Bio = "Saif Ali Khan is an Indian actor and producer who works in Hindi cinema. Part of the Pataudi family, he is the son of actress Sharmila Tagore and cricketer Mansoor Ali Khan Pataudi. Khan made his acting debut in Parampara.",
                                ProfilePictureURL = "https://m.media-amazon.com/images/M/MV5BMTUyNjI2NTg3M15BMl5BanBnXkFtZTcwNDEzNDg3OA@@._V1_.jpg"
                            },
                            new Actor()
                            {
                                FullName = "Akshay Kumar",
                                Bio = "Rajiv Hari Om Bhatia, known professionally as Akshay Kumar, is an Indian-born naturalised Canadian actor and film producer who works in Hindi cinema. In over 30 years of acting, Kumar has appeared in some 100 films and has won several awards, including a National Film Award for Best Actor and two Filmfare Awards.",
                                ProfilePictureURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQo6-IEFRfuWIHtgpxhoDgqyfhRWyQyUSvLnbJsJJukaiYXzdPu"
                            }
                        });
                            context.SaveChanges();
                        }
                        //Producers
                        if (!context.Producers.Any())
                        {
                            context.Producers.AddRange(new List<Producer>()
                        {
                            new Producer()
                            {
                                FullName = "Sanjay Leela Bhansali",
                                Bio = "Sanjay Leela Bhansali, (born 24 February 1963) is an Indian filmmaker, director, screenwriter, and music composer who is known for his work in Hindi cinema. He is the recipient of several awards, including four National Film Awards, ten Filmfare Awards and a BAFTA nomination.[1] In 2015, the Government of India honoured him with the Padma Shri, the fourth highest civilian award.",
                                ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9a/Sanjay_Leela_Bhansali.jpg/220px-Sanjay_Leela_Bhansali.jpg"

                            },
                            new Producer()
                            {
                                FullName = "Mahesh Bhatt",
                                Bio = "Mahesh Bhatt (born 20 September 1948) is an Indian film director, producer and screenwriter known for his works in Hindi cinema. A stand-out film from his earlier period is Saaransh (1984), screened at the 14th Moscow International Film Festival. It became India's official entry for the Academy Award for Best Foreign Language Film for that year.[1] The 1986 film Naam was his first piece of commercial cinema.[2] In 1987, he turned producer with the film Kabzaa under the banner, Vishesh Films, with his brother Mukesh Bhatt.",
                                ProfilePictureURL = "https://starsunfolded.com/wp-content/uploads/2017/03/Mahesh-Bhatt.jpg"
                            },
                            new Producer()
                            {
                                FullName = "Ekta Kapoor",
                                Bio = "Ekta Kapoor (born 7 June 1975) is an Indian television producer, film producer and director who works in Hindi cinema and soap opera. She is the joint managing director and creative head of Balaji Telefilms Limited, which was founded in 1994. In 2001, Balaji Motion Pictures was launched as a subsidiary company of Balaji Telefilms Limited which is a film production and distribution company. She launched ALT Balaji in April 2017.",
                                ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e1/Ekta_Kapoor_in_2021.jpg/220px-Ekta_Kapoor_in_2021.jpg"
                            },
                            new Producer()
                            {
                                FullName = "Siddharth Roy Kapur",
                                Bio = "Siddharth Roy Kapur (born 2 August 1974) is an Indian film producer and president of the Producers Guild of India.[1] As founder and managing director of Roy Kapur Films, former CEO of UTV Motion Pictures and managing director of The Walt Disney Company India., Roy Kapur's filmography as a producer has received both commercial success and critical acclaim.",
                                ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/en/thumb/8/8f/Siddharth_Roy_Kapur_1.jpg/220px-Siddharth_Roy_Kapur_1.jpg"
                            },
                            new Producer()
                            {
                                FullName = "Sajid Nadiadwala",
                                Bio = "Sajid Nadiadwala (born 18 February 1966)[1] is an Indian film producer, writer, and director who works in Hindi cinema. He is the owner of Nadiadwala Grandson Entertainment. Grandson of filmmaker A.K. Nadiadwala, Sajid has written and produced films including Housefull (2010), Baaghi (2016) to directing Kick (2014) that brought him various debutant director awards, and wrote the Marathi film Lai Bhaari that was produced by Riteish Deshmukh.",
                                ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/68/Sajid_Nadiadwala_2018.jpg/220px-Sajid_Nadiadwala_2018.jpg"
                            }
                        });
                            context.SaveChanges();
                        }
                        //Movies
                        if (!context.Movies.Any())
                        {
                            context.Movies.AddRange(new List<Movie>()
                        {
                            new Movie()
                            {
                                Name = "Lagaan (2001)",
                                Description = "The people of a small village in Victorian India stake their future on a game of cricket against their ruthless British rulers.",
                                Price = 39.50,
                                ImageURL = "https://m.media-amazon.com/images/M/MV5BNmYxZGJlNmQtMWY3OS00Njc0LThjODgtOWEwMWU4NTUxMDExXkEyXkFqcGdeQXVyNDAzNDk0MTQ@._V1_UY209_CR3,0,140,209_AL_.jpg",
                                StartDate = DateTime.Now.AddDays(-10),
                                EndDate = DateTime.Now.AddDays(10),
                                CinemaId = 3,
                                ProducerId = 3,
                                MovieCategory = MovieCategory.Drama
                            },
                            new Movie()
                            {
                                Name = "Gangs of Wasseypur (2012)",
                                Description = "A clash between Sultan and Shahid Khan leads to the expulsion of Khan from Wasseypur, and ignites a deadly blood feud spanning three generations.",
                                Price = 29.50,
                                ImageURL = "https://m.media-amazon.com/images/M/MV5BMTc5NjY4MjUwNF5BMl5BanBnXkFtZTgwODM3NzM5MzE@._V1_UY209_CR0,0,140,209_AL_.jpg",
                                StartDate = DateTime.Now,
                                EndDate = DateTime.Now.AddDays(3),
                                CinemaId = 1,
                                ProducerId = 1,
                                MovieCategory = MovieCategory.Action
                            },
                            new Movie()
                            {
                                Name = "Rang De Basanti (2006)",
                                Description = "The story of six young Indians who assist an English woman to film a documentary on the freedom fighters from their past, and the events that lead them to relive the long-forgotten saga of freedom.",
                                Price = 39.50,
                                ImageURL = "https://m.media-amazon.com/images/M/MV5BYThmZDA0YmQtMWJhNy00MDQwLTk0Y2YtMDhmZTE5ZjhlNjliXkEyXkFqcGdeQXVyODE5NzE3OTE@._V1_UY209_CR3,0,140,209_AL_.jpg",
                                StartDate = DateTime.Now,
                                EndDate = DateTime.Now.AddDays(7),
                                CinemaId = 4,
                                ProducerId = 4,
                                MovieCategory = MovieCategory.Drama
                            },
                            new Movie()
                            {
                                Name = "Mughal-E-Azam",
                                Description = "A 16th century prince falls in love with a court dancer and battles with his emperor father.",
                                Price = 39.50,
                                ImageURL = "https://m.media-amazon.com/images/M/MV5BMmM2YWQ3MzctOTk1NS00NThhLWExY2MtYjQzZGRmZTFiYWY3XkEyXkFqcGdeQXVyMjUxMTY3ODM@._V1_UY209_CR6,0,140,209_AL_.jpg",
                                StartDate = DateTime.Now.AddDays(-10),
                                EndDate = DateTime.Now.AddDays(-5),
                                CinemaId = 1,
                                ProducerId = 2,
                                MovieCategory = MovieCategory.Romance
                            },
                            new Movie()
                            {
                                Name = "3 idiots",
                                Description = "Two friends are searching for their long lost companion. They revisit their college days and recall the memories of their friend who inspired them to think differently, even as the rest of the world called them idiots",
                                Price = 39.50,
                                ImageURL = "https://m.media-amazon.com/images/M/MV5BNTkyOGVjMGEtNmQzZi00NzFlLTlhOWQtODYyMDc2ZGJmYzFhXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_UY209_CR2,0,140,209_AL_.jpg",
                                StartDate = DateTime.Now.AddDays(-10),
                                EndDate = DateTime.Now.AddDays(-2),
                                CinemaId = 1,
                                ProducerId = 3,
                                MovieCategory = MovieCategory.Comedy
                            },
                            new Movie()
                            {
                                Name = "Shershaah",
                                Description = "Shershaah is the story of PVC awardee Indian soldier Capt. Vikram Batra, whose bravery and unflinching courage in chasing the Pakistani soldiers out of Indian territory contributed immensely in India finally winning the Kargil War in 1999.",
                                Price = 39.50,
                                ImageURL = "https://m.media-amazon.com/images/M/MV5BMjk1NzcwMDUtNDU4ZC00MzlhLTkzZjAtM2MxMTRjZGE0ODdhXkEyXkFqcGdeQXVyODE5NzE3OTE@._V1_UY209_CR8,0,140,209_AL_.jpg",
                                StartDate = DateTime.Now.AddDays(3),
                                EndDate = DateTime.Now.AddDays(20),
                                CinemaId = 1,
                                ProducerId = 5,
                                MovieCategory = MovieCategory.Action
                            }
                        });
                            context.SaveChanges();
                        }
                        //Actors & Movies
                        if (!context.Actors_Movies.Any())
                        {
                            context.Actors_Movies.AddRange(new List<Actor_Movie>()
                        {
                            new Actor_Movie()
                            {
                                ActorId = 1,
                                MovieId = 1
                            },
                            new Actor_Movie()
                            {
                                ActorId = 3,
                                MovieId = 1
                            },

                             new Actor_Movie()
                            {
                                ActorId = 1,
                                MovieId = 2
                            },
                             new Actor_Movie()
                            {
                                ActorId = 4,
                                MovieId = 2
                            },

                            new Actor_Movie()
                            {
                                ActorId = 1,
                                MovieId = 3
                            },
                            new Actor_Movie()
                            {
                                ActorId = 2,
                                MovieId = 3
                            },
                            new Actor_Movie()
                            {
                                ActorId = 5,
                                MovieId = 3
                            },


                            new Actor_Movie()
                            {
                                ActorId = 2,
                                MovieId = 4
                            },
                            new Actor_Movie()
                            {
                                ActorId = 3,
                                MovieId = 4
                            },
                            new Actor_Movie()
                            {
                                ActorId = 4,
                                MovieId = 4
                            },


                            new Actor_Movie()
                            {
                                ActorId = 2,
                                MovieId = 5
                            },
                            new Actor_Movie()
                            {
                                ActorId = 3,
                                MovieId = 5
                            },
                            new Actor_Movie()
                            {
                                ActorId = 4,
                                MovieId = 5
                            },
                            new Actor_Movie()
                            {
                                ActorId = 5,
                                MovieId = 5
                            },


                            new Actor_Movie()
                            {
                                ActorId = 3,
                                MovieId = 6
                            },
                            new Actor_Movie()
                            {
                                ActorId = 4,
                                MovieId = 6
                            },
                            new Actor_Movie()
                            {
                                ActorId = 5,
                                MovieId = 6
                            },
                        });
                            context.SaveChanges();
                        }
                    }

                }


            }
        public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {

                //Roles
                var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
                if (!await roleManager.RoleExistsAsync(UserRoles.User))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.User));

                //Users
                var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
                string adminUserEmail = "admin@etickets.com";

                var adminUser = await userManager.FindByEmailAsync(adminUserEmail);
                if (adminUser == null)
                {
                    var newAdminUser = new ApplicationUser()
                    {
                        FullName = "Admin User",
                        UserName = "admin-user",
                        Email = adminUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAdminUser, "Coding@1234?");
                    await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
                }


                string appUserEmail = "user@etickets.com";

                var appUser = await userManager.FindByEmailAsync(appUserEmail);
                if (appUser == null)
                {
                    var newAppUser = new ApplicationUser()
                    {
                        FullName = "Application User",
                        UserName = "app-user",
                        Email = appUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAppUser, "Coding@1234?");
                    await userManager.AddToRoleAsync(newAppUser, UserRoles.User);
                }
            }
        }
    }

}