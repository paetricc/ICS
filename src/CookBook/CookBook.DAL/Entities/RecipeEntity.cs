﻿using Nemesis.Essentials.Design;
using System;
using System.Collections.Generic;
using CookBook.Common.Enums;

namespace CookBook.DAL.Entities;

public record RecipeEntity(
    Guid Id, 
    string Name, 
    string Description, 
    TimeSpan Duration, 
    FoodType FoodType, 
    string? ImageUrl) : EntityBase(Id: Id)
{
    //TODO remove after repository refactoring
#nullable disable
    public RecipeEntity() : this(default, default, default, default, default, default)
    {
    }
#nullable enable
    
    public ICollection<IngredientAmountEntity> Ingredients { get; init; } = new List<IngredientAmountEntity>();
}
