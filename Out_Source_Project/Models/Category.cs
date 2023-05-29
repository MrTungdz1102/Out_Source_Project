﻿using System;
using System.Collections.Generic;

namespace Out_Source_Project.Models;

public partial class Category
{
    public int CatId { get; set; }

    public string? CatName { get; set; }

    public string? Title { get; set; }

    public string? Alias { get; set; }

    public string? MetaDesc { get; set; }

    public string? MetaKey { get; set; }

    public string? Thumb { get; set; }

    public bool Published { get; set; }

    public int? Ordering { get; set; }

    public int? Parents { get; set; }

    public int? Levels { get; set; }

    public string? Icon { get; set; }

    public string? Cover { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<Post> Posts { get; set; } = new List<Post>();
}
