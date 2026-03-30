using System;
using System.Collections.Generic;

namespace pr_DBContext.Domaind.Database.SqlServer.Entities;

public partial class Like
{
    public int Id { get; set; }

    public Guid UserId { get; set; }

    public int PostId { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual Post Post { get; set; } = null!;

    public virtual Usuario User { get; set; } = null!;
}
