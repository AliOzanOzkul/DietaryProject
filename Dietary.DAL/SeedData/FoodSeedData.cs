﻿using Dietary.Entities.Entities.EnumEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dietary.DAL.SeedData
{
    internal class FoodSeedData
    {
        public void FSeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Food>().HasData
                (
                new Food { Id = 1, Name = "Grilled chicken", CaloryPerGram = 1.19M, PhotoPath = ".\\Grilled Chicken.jpg" },
                new Food { Id = 2, Name = "Steak", CaloryPerGram = 2.89M, PhotoPath = ".\\Steak.jpg" },
                new Food { Id = 3, Name = "Salmon", CaloryPerGram = 2.19M, PhotoPath = ".\\Salmon.jpg" },
                new Food { Id = 4, Name = "Tuna", CaloryPerGram = 1.29M, PhotoPath = ".\\Tuna.jpg" },
                new Food { Id = 5, Name = "Cod", CaloryPerGram = 0.89M, PhotoPath = ".\\Cod.jpg" },
                new Food { Id = 6, Name = "Shrimp", CaloryPerGram = 1.99M, PhotoPath = ".\\Shrimp.jpg" },
                new Food { Id = 7, Name = "Beef stir-fry", CaloryPerGram = 1.79M, PhotoPath = ".\\Beef stir-fry.jpg" },
                new Food { Id = 8, Name = "Chicken fajitas", CaloryPerGram = 1.39M, PhotoPath = ".\\Chicken fajitas.jpg" },
                new Food { Id = 9, Name = "Meatloaf", CaloryPerGram = 2.09M, PhotoPath = ".\\Meatloaf.jpg" },
                new Food { Id = 10, Name = "Grilled fish", CaloryPerGram = 1.59M, PhotoPath = ".\\Grilled fish.jpg" },
                new Food { Id = 11, Name = "Pork chops", CaloryPerGram = 2.49M, PhotoPath = ".\\Pork chops.jpg" },
                new Food { Id = 12, Name = "Chicken parmesan", CaloryPerGram = 2.29M, PhotoPath = ".\\Chicken parmesan.jpg" },
                new Food { Id = 13, Name = "Beef stew", CaloryPerGram = 1.89M, PhotoPath = ".\\Beef stew.jpg" },
                new Food { Id = 14, Name = "Pasta with meat sauce", CaloryPerGram = 1.69M, PhotoPath = ".\\Bacon.jpg" },
                new Food { Id = 15, Name = "Meatballs", CaloryPerGram = 1.49M, PhotoPath = ".\\Meatballs.jpg" },
                new Food { Id = 16, Name = "Turkey chili", CaloryPerGram = 1.59M, PhotoPath = ".\\Turkey chili.jpg" },
                new Food { Id = 17, Name = "Beef burgers", CaloryPerGram = 2.79M, PhotoPath = ".\\Beef burgers.jpg" },
                new Food { Id = 18, Name = "Chicken curry", CaloryPerGram = 1.99M, PhotoPath = ".\\Chicken curry.jpg" },
                new Food { Id = 19, Name = "Spaghetti Bolognese", CaloryPerGram = 1.79M, PhotoPath = ".\\Spaghetti bolognese.jpg" },
                new Food { Id = 20, Name = "Roasted pork loin", CaloryPerGram = 2.39M, PhotoPath = ".\\Roasted pork loin.jpg" },
                new Food { Id = 21, Name = "Grilled Eggplant", CaloryPerGram = 0.25M, PhotoPath = ".\\Grilled Eggplant.jpg" },
                new Food { Id = 22, Name = "Stuffed Zucchini", CaloryPerGram = 0.39M, PhotoPath = ".\\Stuffed Zucchini.jpg" },
                new Food { Id = 23, Name = "Roasted Brussels Sprouts", CaloryPerGram = 0.43M, PhotoPath = ".\\Roasted brussel sprouts.jpg" },
                new Food { Id = 24, Name = "Cauliflower Fried Rice", CaloryPerGram = 0.4M, PhotoPath = ".\\Fried rice.jpg" },
                new Food { Id = 25, Name = "Sautéed Kale", CaloryPerGram = 0.27M, PhotoPath = ".\\Sautéed Kale.jpg" },
                new Food { Id = 26, Name = "Roasted Sweet Potatoes", CaloryPerGram = 0.76M, PhotoPath = ".\\Roasted sweet potatoes.jpg" },
                new Food { Id = 27, Name = "Stir-Fried Bok Choy", CaloryPerGram = 0.12M, PhotoPath = ".\\Stir-fried bok choy.jpg" },
                new Food { Id = 28, Name = "Grilled Asparagus", CaloryPerGram = 0.2M, PhotoPath = ".\\Grilled Asparagus.jpg" },
                new Food { Id = 29, Name = "Roasted Carrots", CaloryPerGram = 0.41M, PhotoPath = ".\\Roasted Carrots.jpg" },
                new Food { Id = 30, Name = "Mushroom Risotto", CaloryPerGram = 0.34M, PhotoPath = ".\\Mushroom Risotto.jpg" },
                new Food { Id = 31, Name = "Steamed broccoli", CaloryPerGram = 0.35M, PhotoPath = ".\\Steamed broccoli.jpg" },
                new Food { Id = 32, Name = "Roasted asparagus", CaloryPerGram = 0.27M, PhotoPath = ".\\Roasted asparagus.jpg" },
                new Food { Id = 33, Name = "Mashed potatoes", CaloryPerGram = 0.86M, PhotoPath = ".\\Mashed potatoes.jpg" },
                new Food { Id = 34, Name = "Garlic green beans", CaloryPerGram = 0.33M, PhotoPath = ".\\Garlic green beans.jpg" },
                new Food { Id = 35, Name = "Grilled zucchini", CaloryPerGram = 0.17M, PhotoPath = ".\\Grilled zucchini.jpg" },
                new Food { Id = 36, Name = "Creamed spinach", CaloryPerGram = 0.69M, PhotoPath = ".\\Creamed spinach.jpg" },
                new Food { Id = 37, Name = "Fried rice", CaloryPerGram = 1.05M, PhotoPath = ".\\Fried rice.jpg" },
                new Food { Id = 38, Name = "Sweet potato fries", CaloryPerGram = 1.3M, PhotoPath = ".\\Sweet potato fries.jpg" },
                new Food { Id = 39, Name = "Baked beans", CaloryPerGram = 0.86M, PhotoPath = ".\\Bakedbeans.jpg" },
                new Food { Id = 40, Name = "Tomato soup", CaloryPerGram = 0.35M, PhotoPath = ".\\Tomato soup.jpg" },
                new Food { Id = 41, Name = "Pumpkin soup", CaloryPerGram = 0.25M, PhotoPath = ".\\Pumpkin soup.jpg" },
                new Food { Id = 42, Name = "Mushroom soup", CaloryPerGram = 0.4M, PhotoPath = ".\\Mushroom soup.jpg" },
                new Food { Id = 43, Name = "Chicken noodle soup", CaloryPerGram = 0.45M, PhotoPath = ".\\Chicken noodle soup.jpg" },
                new Food { Id = 44, Name = "Beef soup", CaloryPerGram = 0.4M, PhotoPath = ".\\Beef soup.jpg" },
                new Food { Id = 45, Name = "Corn soup", CaloryPerGram = 0.35M, PhotoPath = ".\\Corn soup.jpg" },
                new Food { Id = 46, Name = "Minestrone soup", CaloryPerGram = 0.3M, PhotoPath = ".\\Minestrone soup.jpg" },
                new Food { Id = 47, Name = "Vegetable soup", CaloryPerGram = 0.25M, PhotoPath = ".\\Vegetable soup.jpg" },
                new Food { Id = 48, Name = "Clam chowder", CaloryPerGram = 0.5M, PhotoPath = ".\\Clam chowder.jpg" },
                new Food { Id = 49, Name = "Lentil soup", CaloryPerGram = 0.3M, PhotoPath = ".\\Lentil soup.jpg" },
                new Food { Id = 50, Name = "Rice", CaloryPerGram = 3.75M, PhotoPath = ".\\Rice.jpg" },
                new Food { Id = 51, Name = "Bread", CaloryPerGram = 2.64M, PhotoPath = ".\\Bread.jpg" },
                new Food { Id = 52, Name = "Pasta", CaloryPerGram = 3.38M, PhotoPath = ".\\Pasta.jpg" },
                new Food { Id = 53, Name = "Quinoa", CaloryPerGram = 3.68M, PhotoPath = ".\\Quinoa.jpg" },
                new Food { Id = 54, Name = "Bulgur", CaloryPerGram = 3.33M, PhotoPath = ".\\Bulgur.jpg" },
                new Food { Id = 55, Name = "Couscous", CaloryPerGram = 3.81M, PhotoPath = ".\\Couscous.jpg" },
                new Food { Id = 56, Name = "Oats", CaloryPerGram = 3.37M, PhotoPath = ".\\Oats.jpg" },
                new Food { Id = 57, Name = "Barley", CaloryPerGram = 3.44M, PhotoPath = ".\\Barley.jpg" },
                new Food { Id = 58, Name = "Wheat berries", CaloryPerGram = 3.3M, PhotoPath = ".\\Wheat berries.jpg" },
                new Food { Id = 59, Name = "Wild rice", CaloryPerGram = 3.72M, PhotoPath = ".\\Wild rice.jpg" },
                new Food { Id = 60, Name = "Oatmeal", CaloryPerGram = 0.68M, PhotoPath = ".\\Oatmeal.jpg" },
                new Food { Id = 61, Name = "Scrambled Eggs", CaloryPerGram = 1.34M, PhotoPath = ".\\Scrambled eggs.jpg" },
                new Food { Id = 62, Name = "Bacon", CaloryPerGram = 5.42M, PhotoPath = ".\\Bacon.jpg" },
                new Food { Id = 63, Name = "Sausage", CaloryPerGram = 4.85M, PhotoPath = ".\\Sausage.jpg" },
                new Food { Id = 64, Name = "French Toast", CaloryPerGram = 2.92M, PhotoPath = ".\\French toast.jpg" },
                new Food { Id = 65, Name = "Waffles", CaloryPerGram = 2.86M, PhotoPath = ".\\Waffles.jpg" },
                new Food { Id = 66, Name = "Pancakes", CaloryPerGram = 2.52M, PhotoPath = ".\\Pancakes.jpg" },
                new Food { Id = 67, Name = "Bagel", CaloryPerGram = 2.71M, PhotoPath = ".\\Bagel.jpg" },
                new Food { Id = 68, Name = "Cream Cheese", CaloryPerGram = 3.79M, PhotoPath = ".\\Cream Cheese.jpg" },
                new Food { Id = 69, Name = "Fruit Salad", CaloryPerGram = 0.67M, PhotoPath = ".\\Bacon.jpg" },
                new Food { Id = 70, Name = "Popcorn", CaloryPerGram = 5.85M, PhotoPath = ".\\Popcorn.jpg" },
                new Food { Id = 71, Name = "Trail Mix", CaloryPerGram = 4.2M, PhotoPath = ".\\Tail mix.jpg" },
                new Food { Id = 72, Name = "Energy Bars", CaloryPerGram = 4.0M, PhotoPath = ".\\Energy Bars.jpg" },
                new Food { Id = 73, Name = "Fruit Cups", CaloryPerGram = 0.73M, PhotoPath = ".\\Fruit cups.jpg" },
                new Food { Id = 74, Name = "Yogurt Cups", CaloryPerGram = 0.75M, PhotoPath = ".\\Yogurt cups.jpg" },
                new Food { Id = 75, Name = "Nuts", CaloryPerGram = 6.0M, PhotoPath = ".\\Nuts.jpg" },
                new Food { Id = 76, Name = "Cheese and Crackers", CaloryPerGram = 3.0M, PhotoPath = ".\\Cheese and Crackers.jpg" },
                new Food { Id = 77, Name = "Pretzels", CaloryPerGram = 3.17M, PhotoPath = ".\\Pretzels.jpg" },
                new Food { Id = 78, Name = "Hummus", CaloryPerGram = 1.0M, PhotoPath = ".\\Hummus.jpg" },
                new Food { Id = 79, Name = "Dark Chocolate", CaloryPerGram = 5.0M, PhotoPath = ".\\Dark chocolate.jpg" },
                new Food { Id = 80, Name = "Water", CaloryPerGram = 0, PhotoPath = ".\\Water.jpg" },
                new Food { Id = 81, Name = "Tea", CaloryPerGram = 0.16M, PhotoPath = ".\\Tea.jpg" },
                new Food { Id = 82, Name = "Coffee", CaloryPerGram = 0.1M, PhotoPath = ".\\Coffee.jpg" },
                new Food { Id = 83, Name = "Juice", CaloryPerGram = 0.44M, PhotoPath = ".\\Juice.jpg" },
                new Food { Id = 84, Name = "Milk", CaloryPerGram = 0.67M, PhotoPath = ".\\Milk.jpg" },
                new Food { Id = 85, Name = "Soda", CaloryPerGram = 0.41M, PhotoPath = ".\\Soda.jpg" },
                new Food { Id = 86, Name = "Mineral Water", CaloryPerGram = 0, PhotoPath = ".\\Mineral Water.jpg" },
                new Food { Id = 87, Name = "Turkhis Coffee", CaloryPerGram = 0.1M, PhotoPath = ".\\Bacon.jpg" },
                new Food { Id = 88, Name = "Lemonade", CaloryPerGram = 0.4M, PhotoPath = ".\\Lemonade.jpg" },
                new Food { Id = 89, Name = "Smoothie", CaloryPerGram = 0.56M, PhotoPath = ".\\Smoothie.jpg" },
                new Food { Id = 90, Name = "Caesar Salad", CaloryPerGram = 1.13M, PhotoPath = ".\\Caesar salad.jpg" },
                new Food { Id = 91, Name = "Cobb Salad", CaloryPerGram = 1.05M, PhotoPath = ".\\Cobb salad.jpg" },
                new Food { Id = 92, Name = "Greek Salad", CaloryPerGram = 0.96M, PhotoPath = ".\\Greek salad.jpg" },
                new Food { Id = 93, Name = "Caprese Salad", CaloryPerGram = 0.89M, PhotoPath = ".\\Caprese salad.jpg" },
                new Food { Id = 94, Name = "Spinach Salad", CaloryPerGram = 0.81M, PhotoPath = ".\\Spinach salad.jpg" },
                new Food { Id = 95, Name = "Coleslaw", CaloryPerGram = 0.76M, PhotoPath = ".\\Coleslaw.jpg" },
                new Food { Id = 96, Name = "Waldorf Salad", CaloryPerGram = 0.92M, PhotoPath = ".\\Waldorf salad.jpg" },
                new Food { Id = 97, Name = "Beetroot Salad", CaloryPerGram = 0.78M, PhotoPath = ".\\Beetroot salad.jpg" },
                new Food { Id = 98, Name = "Pasta Salad", CaloryPerGram = 0.88M, PhotoPath = ".\\Pasta Salad.jpg" },
                new Food { Id = 99, Name = "Tuna Salad", CaloryPerGram = 0.98M, PhotoPath = ".\\Tuna salad.jpg" },
                new Food { Id = 100, Name = "Chocolate cake", CaloryPerGram = 3.87M, PhotoPath = ".\\Chocolate Cake.jpg" },
                new Food { Id = 101, Name = "Apple pie", CaloryPerGram = 2.8M, PhotoPath = ".\\Applepie.jpg" },
                new Food { Id = 102, Name = "Pumpkin pie", CaloryPerGram = 3.0M, PhotoPath = ".\\Pumpkin pie.jpg" },
                new Food { Id = 103, Name = "Cheesecake", CaloryPerGram = 3.2M, PhotoPath = ".\\Cheesecake.jpg" },
                new Food { Id = 104, Name = "Strawberry shortcake", CaloryPerGram = 2.89M, PhotoPath = ".\\Strawberry Shortcake.jpg" },
                new Food { Id = 105, Name = "Ice cream", CaloryPerGram = 1.5M, PhotoPath = ".\\Ice Cream.jpg" },
                new Food { Id = 106, Name = "Brownie", CaloryPerGram = 3.6M, PhotoPath = ".\\Brownie.jpg" },
                new Food { Id = 107, Name = "Fruit salad", CaloryPerGram = 1.08M, PhotoPath = ".\\Fruit Salad.jpg" },
                new Food { Id = 108, Name = "Banana pudding", CaloryPerGram = 1.83M, PhotoPath = ".\\Bananapudding.jpg" },
                new Food { Id = 109, Name = "Tiramisu", CaloryPerGram = 3.1M, PhotoPath = ".\\Tiramisu.jpg" },
                new Food { Id = 110, Name = "Apple", CaloryPerGram = 0.52M, PhotoPath = ".\\Apple.jpg" },
                new Food { Id = 111, Name = "Banana", CaloryPerGram = 0.89M, PhotoPath = ".\\Bacon.jpg" },
                new Food { Id = 112, Name = "Orange", CaloryPerGram = 0.47M, PhotoPath = ".\\Orange.jpg" },
                new Food { Id = 113, Name = "Strawberry", CaloryPerGram = 0.32M, PhotoPath = ".\\Strawberry.jpg" },
                new Food { Id = 114, Name = "Watermelon", CaloryPerGram = 0.3M, PhotoPath = ".\\Watermelon.jpg" },
                new Food { Id = 115, Name = "Grape", CaloryPerGram = 0.69M, PhotoPath = ".\\Grape.jpg" },
                new Food { Id = 116, Name = "Pineapple", CaloryPerGram = 0.5M, PhotoPath = ".\\Pineapple.jpg" },
                new Food { Id = 117, Name = "Kiwi", CaloryPerGram = 0.61M, PhotoPath = ".\\Kiwi.jpg" },
                new Food { Id = 118, Name = "Cherry", CaloryPerGram = 0.5M, PhotoPath = ".\\Cherry.jpg" },
                new Food { Id = 119, Name = "Mango", CaloryPerGram = 0.6M, PhotoPath = ".\\Mango.jpg" }
            );
        }

    }
}