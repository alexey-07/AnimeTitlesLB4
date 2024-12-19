using System;
using System.Collections.Generic;

namespace AnimeTitles.Models;

public partial class AnimeType
{
    public short Id { get; set; }

    public string AnimeOfType { get; set; } = null!;
    // навигационное свойство
    public virtual ICollection<AnimeTitle> AnimeTitles { get; set; } = new List<AnimeTitle>();
}
