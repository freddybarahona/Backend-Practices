using System;
using System.Collections.Generic;

namespace pr_DBContext.Domaind.Database.SqlServer.Entities;

public partial class Seguidore
{
    public Guid FollowerId { get; set; }

    public Guid FollowingId { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual Usuario Follower { get; set; } = null!;

    public virtual Usuario Following { get; set; } = null!;
}
