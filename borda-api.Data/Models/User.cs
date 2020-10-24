using Microsoft.AspNetCore.Identity;
using System;

public class User: IdentityUser
{
    public string Login { get; set; }
    public string FullName { get; set; }
    public bool Active { get; set; }
}