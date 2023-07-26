﻿using Microsoft.AspNetCore.Http;
using NicesleepingShop.Domain.Enum;

namespace NicesleepingShop.Service.Dtos.Products;

public class ProductCreateDto
{
    public long CategoryId { get; set; }

    public string Name { get; set; } = string.Empty;

    public MaterialStatus Status { get; set; }

    public IFormFile Image { get; set; } = default!;

    public double UnitPrice { get; set; }

    public string Description { get; set; } = string.Empty;
}
