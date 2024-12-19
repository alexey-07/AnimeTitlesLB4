﻿using System;
using System.Collections.Generic;

namespace AnimeTitles.Models;

public partial class Genre
{
    public short Id { get; set; }

    public string GenreName { get; set; } = null!;
    // навигационное свойство
    public virtual ICollection<AnimeTitle> AnimeTitles { get; set; } = new List<AnimeTitle>();
}