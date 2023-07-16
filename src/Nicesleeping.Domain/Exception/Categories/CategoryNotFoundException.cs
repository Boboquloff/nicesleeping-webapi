﻿namespace NicesleepingShop.Domain.Exception.Categories;

public class CategoryNotFoundException:NotFoundException
{
    public CategoryNotFoundException()
    {
        this.TitleMessage = "Category not found!";
    }
}
