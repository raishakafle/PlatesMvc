using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PlatesMvc.Data;
using System;
using System.Linq;

namespace PlatesMvc.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ApplicationDbContext>>()))
            {
                // Look for any plates.
                if (context.Plates.Any())
                {
                    return;   // DB has been seeded
                }


                //Added field and its respective properties to it.

                context.Plates.AddRange(

                    //One
                    new Plates
                    {
                        Material = "Glass",
                        ManufacturedDate = 2003,
                        Design = "Solid",
                        Size = "S",
                        Shape = "Dinner Plate",
                        Function = "Homely"


                    },

                    //Two
                    new Plates
                    {
                        Material = "Porcelain",
                        ManufacturedDate = 1945,
                        Design = "Floral",
                        Size = "M",
                        Shape = "Salad Plate",
                        Function = "Homely"


                    },

                    //Three
                    new Plates
                    {
                        Material = "Ceramic",
                        ManufacturedDate = 2017,
                        Design = "Geometeric",
                        Size = "S",
                        Shape = "Dessert Plate",
                        Function = "Aesthetic"


                    },

                    //Four
                    new Plates
                    {
                        Material = "Wood",
                        ManufacturedDate = 2012,
                        Design = "Abstract",
                        Size = "L",
                        Shape = "Bread Plate",
                        Function = "Breakfast"


                    },

                    //Five
                    new Plates
                    {
                        Material = "Plastic",
                        ManufacturedDate = 1999,
                        Design = "Animal Print",
                        Size = "M",
                        Shape = "Charger Plate",
                        Function = "Aesthetic"


                    },

                    //Six
                    new Plates
                    {
                        Material = "Melamine",
                        ManufacturedDate = 2010,
                        Design = "Textured",
                        Size = "M",
                        Shape = "Appetizer Plate",
                        Function = "Fancy"


                    },

                    //Seven
                    new Plates
                    {
                        Material = "Stainless Steel",
                        ManufacturedDate = 2020,
                        Design = "Holiday Themed", 
                        Size = "L",
                        Shape = "Soup Bowl",
                        Function = "Homely"


                    },

                    //Eight
                    new Plates
                    {
                        Material = "Bamboo",
                        ManufacturedDate = 2023,
                        Design = "Ethnic",
                        Size = "L",
                        Shape = "Pasta Bowl",
                        Function = "Fancy"


                    },


                    //Nine
                    new Plates
                    {
                        Material = "Earthenware",
                        ManufacturedDate = 2018,
                        Design = "Minimalistic",
                        Size = "S",
                        Shape = "Platter",
                        Function = "Aesthetic"


                    },

                    //Ten
                    new Plates
                    {
                        Material = "Stone",
                        ManufacturedDate = 2003,
                        Design = "Personalized",
                        Size = "M",
                        Shape = "Sushi Plate",
                        Function = "Fancy"


                    }

                    //Fields  and properties end. 
                );
                context.SaveChanges();
            }
        }
    }
}


















