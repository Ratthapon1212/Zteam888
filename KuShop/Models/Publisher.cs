using System;
using System.Collections.Generic;

namespace KuShop.Models;

public partial class Publisher
{
    public string PubId { get; set; } = null!;

    public string? PubName { get; set; }

    public string? PubContact { get; set; }

    public string? PubTel { get; set; }

    public string? PubEmail { get; set; }

    public string? PubAdd { get; set; }

    public string? PubRemark { get; set; }
}
