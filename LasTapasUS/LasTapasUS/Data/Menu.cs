using Microsoft.AspNetCore.Routing;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections.Generic;
using LasTapasUS.Models;

namespace LasTapasUS.Data
{
    public class Menu
    {
        public static List<MenuItem> MenuList = new()
        { 
        //Cold Tapas
        new() { Category="Cold Tapas", Name="Aceitunas mixtas", Description="Marinated olives with garlic and herbs", Price=3.50m, ImagePath="wwwroot/images/dishes/Aceitunas-Mixtas.png", },//allergens toevoegen
        new() { Category="Cold Tapas", Name="Jamón Ibérico", Description="Iberian ham with crispy bread", Price=8.50m, ImagePath="wwwroot/images/dishes/Jamón-Ibérico.jpg", },//allergens toevoegen
        new() { Category = "Cold Tapas", Name = "Queso Manchego", Description = "Sheep cheese with fig compote", Price = 6.50m, ImagePath="wwwroot/images/dishes/Queso-Manchego.jpg" },//allergens toevoegen
        new() { Category = "Cold Tapas", Name = "Pan con tomate", Description = "Toasted bread with tomato and olive oil", Price = 4.50m, ImagePath = "wwwroot/images/dishes/Pan-con-tomate.jpg", },//allergens toevoegen
        new() { Category = "Cold Tapas", Name = "Ensaladilla rusa", Description = "Potato salad with tuna and egg", Price = 5.50m, ImagePath = "wwwroot/images/dishes/Ensaladilla-rusa.jpg", },//allergens toevoegen
        new() { Category = "Cold Tapas", Name = "Gazpacho andaluz", Description = "Cold tomato soup with cucumber", Price = 4.50m, ImagePath = "wwwroot/images/dishes/Gazpacho-andaluz.jpg", },//allergens toevoegen

        //Hot Tapas
        new() { Category = "Hot Tapas", Name = "Patatas bravas", Description = "Crispy potatoes with spicy sauce", Price = 5.50m, ImagePath = "wwwroot/images/dishes/Patatas-bravas.jpg", },//allergens toevoegen
        new() { Category = "Hot Tapas", Name = "Croquetas de jamón", Description = "Creamy ham croquettes", Price = 5.00m, ImagePath = "wwwroot/images/dishes/Croquetas-de-jamón.jpg", },//allergens toevoegen
        new() { Category = "Hot Tapas", Name = "Albondigas en salsa", Description = "Meatballs in tomato sauce", Price = 6.00m, ImagePath = "wwwroot/images/dishes/albondigas-en-salsa.jpg", },//allergens toevoegen
        new() { Category = "Hot Tapas", Name = "Calamares fritos", Description = "Fried squid rings with lemon", Price = 7.00m, ImagePath = "wwwroot/images/dishes/Calamares-fritos.jpg", },//allergens toevoegen
        new() { Category = "Hot Tapas", Name = "Tortilla española", Description = "Potato omelet with onion", Price = 4.50m, ImagePath = "wwwroot/images/dishes/Tortilla-española.jpg", },//allergens toevoegen
        new() { Category = "Hot Tapas", Name = "Pimientos de padrón", Description = "Fried green peppers with sea salt", Price = 5.00m, ImagePath = "wwwroot/images/dishes/Pimientos-de-padrón.jpg", },//allergens toevoegen
        new() { Category = "Hot Tapas", Name = "Chorizo al vino", Description = "Sausages in red wine", Price = 6.00m, ImagePath = "wwwroot/images/dishes/Chorizo-al-vino.jpg", },//allergens toevoegen
        new() { Category = "Hot Tapas", Name = "Gambas al ajillo", Description = "Shrimp in garlic oil", Price = 8.50m,ImagePath = "wwwroot/images/dishes/Gambas-al-ajillo.jpg", },//allergens toevoegen
        new() { Category = "Hot Tapas", Name = "Empanadillas de pollo", Description = "Chicken-filled pastries", Price = 6.00m, ImagePath = "wwwroot/images/dishes/Emoanadillas-de-pollo.jpg", },//allergens toevoegen

            //Land & Sea
            new() { Category = "Land & Sea", Name = "Pulpo a la gallega", Description = "Octopus with paprika", Price = 9.00m, ImagePath = "wwwroot/images/dishes/Pulpo-a-la-gallega.jpg", },//allergens toevoegen
            new() { Category = "Land & Sea", Name = "Datiles con bacon", Description = "Dates with bacon and almonds", Price = 5.50m,ImagePath = "wwwroot/images/dishes/Datiles-con-bacon.jpg",  },//allergens toevoegen
            new() { Category = "Land & Sea", Name = "Pinchos morunos", Description = "Spiced meat skewers", Price = 7.50m, ImagePath = "wwwroot/images/dishes/Pinchos-morunos.jpg", },//allergens toevoegen
            new() { Category = "Land & Sea", Name = "Bacalao rebozado", Description = "Fried cod", Price = 8.00m, ImagePath= "wwwroot/images/dishes/Bacalao-rebozado.jpg", },//allergens toevoegen
            new() { Category = "Land & Sea", Name = "Costillas ibéricas", Description = "Pork ribs with honey", Price = 9.00m, ImagePath = "wwwroot/images/dishes/Costillas-ibéricas.png", },//allergens toevoegen

            //Dishes to Share
            new() { Category = "Dishes to Share", Name = "Paella mixta", Description = "Paella with chicken, seafood, and saffron", Price = 15.00m, ImagePath = "wwwroot/images/dishes/Paella-mixtajpg", },//allergens toevoegen
            new() { Category = "Dishes to Share", Name = "Tabla de tapas mixtas", Description = "Selection of six tapas (chef’s choice)", Price = 17.50m, ImagePath = "wwwroot/images/dishes/Tabla-de-taoas-mixtas.png", },//allergens toevoegen

            //Desserts
            new() { Category = "Desserts", Name = "Crema catalana", Description = "Spanish crème brûlée", Price = 5.50m, ImagePath = "wwwroot/images/dishes/Crema-catalana.jpg", },//allergens toevoegen
            new() { Category = "Desserts", Name = "Churros con chocolate", Description = "Warm churros with chocolate sauce", Price = 5.00m, ImagePath = "wwwroot/images/dishes/Churros-con-chocolate.jpg", },//allergens toevoegen
            new() { Category = "Desserts", Name = "Tarta de Santiago", Description = "Almond cake with powdered sugar", Price = 5.00m, ImagePath = "wwwroot/images/dishes/tarta-de-santiago.jpg", },//allergens toevoegen
        };
            
    }
}
