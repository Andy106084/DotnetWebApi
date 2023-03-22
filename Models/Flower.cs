﻿using System;
using System.Collections.Generic;

namespace DotnetWebApi.Models;

public partial class Flower
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Language { get; set; } = null!;

    public virtual ICollection<FlowerGiver> FlowerGivers { get; } = new List<FlowerGiver>();

    public virtual ICollection<FlowerOwnership> FlowerOwnerships { get; } = new List<FlowerOwnership>();
}