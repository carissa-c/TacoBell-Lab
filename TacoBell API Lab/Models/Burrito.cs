﻿using System;
using System.Collections.Generic;

namespace TacoBell_API_Lab.Models;

public partial class Burrito
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public float? Cost { get; set; }

    public bool? Bean { get; set; }
}
