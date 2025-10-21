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
        //  Tapas Frías
        new () { Category="Tapas Frías", Name="Aceitunas mixtas", Description="Gemarineerde olijven met knoflook en kruiden", Price=3.50m },
        new() { Category="Tapas Frías", Name="Jamón Ibérico", Description="Iberische ham met krokant brood", Price=8.50m },
        new() { Category = "Tapas Frías", Name = "Queso Manchego", Description = "Schapenkaas met vijgencompote", Price = 6.50m },
        new() { Category = "Tapas Frías", Name = "Pan con tomate", Description = "Geroosterd brood met tomaat en olijfolie", Price = 4.50m },
        new() { Category = "Tapas Frías", Name = "Ensaladilla rusa", Description = "Aardappelsalade met tonijn en ei", Price = 5.50m },
        new() { Category = "Tapas Frías", Name = "Gazpacho andaluz", Description = "Koude tomatensoep met komkommer", Price = 4.50m },

        // Tapas Calientes
        new() { Category = "Tapas Calientes", Name = "Patatas bravas", Description = "Krokante aardappels met pittige saus", Price = 5.50m },
        new() { Category = "Tapas Calientes", Name = "Croquetas de jamón", Description = "Romige hamkroketjes", Price = 5.00m },
        new() { Category = "Tapas Calientes", Name = "Albondigas en salsa", Description = "Gehaktballetjes in tomatensaus", Price = 6.00m },
        new() { Category = "Tapas Calientes", Name = "Calamares fritos", Description = "Inktvisringen met citroen", Price = 7.00m },
        new() { Category = "Tapas Calientes", Name = "Tortilla española", Description = "Aardappelomelet met ui", Price = 4.50m },
        new() { Category = "Tapas Calientes", Name = "Pimientos de padrón", Description = "Gebakken groene pepers met zeezout", Price = 5.00m },
        new() { Category = "Tapas Calientes", Name = "Chorizo al vino", Description = "Worstjes in rode wijn", Price = 6.00m },
       new() { Category = "Tapas Calientes", Name = "Gambas al ajillo", Description = "Garnalen in knoflookolie", Price = 8.50m },
        new() { Category = "Tapas Calientes", Name = "Empanadillas de pollo", Description = "Kipgevulde pasteitjes", Price = 6.00m },

            //  Tapas de la Tierra y el Mar
            new() { Category = "Tapas de la Tierra y el Mar", Name = "Pulpo a la gallega", Description = "Octopus met paprikapoeder", Price = 9.00m },
            new() { Category = "Tapas de la Tierra y el Mar", Name = "Datiles con bacon", Description = "Dadels met spek en amandel", Price = 5.50m },
            new() { Category = "Tapas de la Tierra y el Mar", Name = "Pinchos morunos", Description = "Gekruide vleesspiesjes", Price = 7.50m },
            new() { Category = "Tapas de la Tierra y el Mar", Name = "Bacalao rebozado", Description = "Gefrituurde kabeljauw", Price = 8.00m },
            new() { Category = "Tapas de la Tierra y el Mar", Name = "Costillas ibéricas", Description = "Varkensribbetjes met honing", Price = 9.00m },

            // Platos para Compartir
            new() { Category = "Platos para Compartir", Name = "Paella mixta", Description = "Paella met kip, zeevruchten en saffraan", Price = 15.00m },
            new() { Category = "Platos para Compartir", Name = "Tabla de tapas mixtas", Description = "Selectie van zes tapas (chef’s keuze)", Price = 17.50m },

            // Postres
            new() { Category = "Postres", Name = "Crema catalana", Description = "Spaanse crème brûlée", Price = 5.50m },
            new() { Category = "Postres", Name = "Churros con chocolate", Description = "Warme churros met chocoladesaus", Price = 5.00m },
            new() { Category = "Postres", Name = "Tarta de Santiago", Description = "Amandeltaart met poedersuiker", Price = 5.00m },
        };
            
    }
}
