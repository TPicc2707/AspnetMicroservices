using IdentityModel;
using IdentityServer4;
using IdentityServer4.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text.Json;
using System.Threading.Tasks;

namespace IdentitySecure.Quickstart
{
    public class TestUsers
    {
        public static List<TestUser> Users
        {
            get
            {
                var address = new
                {
                    street_address = "One Hacker Way",
                    locality = "Heidelberg",
                    postal_code = 69118,
                    country = "Germany"
                };

                return new List<TestUser>
                {
                    new TestUser
                    {
                        SubjectId = "818727",
                        Username = "tony",
                        Password = "12345",
                        Claims =
                        {
                            new Claim(JwtClaimTypes.Name, "Tony Piccirilli"),
                            new Claim(JwtClaimTypes.GivenName, "Tony"),
                            new Claim(JwtClaimTypes.FamilyName, "Piccirilli"),
                            new Claim(JwtClaimTypes.Email, "tony@email.com"),
                            new Claim(JwtClaimTypes.EmailVerified, "true", ClaimValueTypes.Boolean),
                            new Claim(JwtClaimTypes.WebSite, "http://alice.com"),
                            new Claim(JwtClaimTypes.Address, JsonSerializer.Serialize(address), IdentityServerConstants.ClaimValueTypes.Json),
                            new Claim(JwtClaimTypes.Role, "user")
                        }
                    },
                    new TestUser
                    {
                        SubjectId = "8842113",
                        Username = "bobby",
                        Password = "bobp",
                        Claims =
                        {
                            new Claim(JwtClaimTypes.Name, "Bobby Smith"),
                            new Claim(JwtClaimTypes.GivenName, "Bobby"),
                            new Claim(JwtClaimTypes.FamilyName, "Smith"),
                            new Claim(JwtClaimTypes.Email, "bobby@email.com"),
                            new Claim(JwtClaimTypes.EmailVerified, "true", ClaimValueTypes.Boolean),
                            new Claim(JwtClaimTypes.WebSite, "http://bobby.com"),
                            new Claim(JwtClaimTypes.Address, JsonSerializer.Serialize(address), IdentityServerConstants.ClaimValueTypes.Json),
                            new Claim(JwtClaimTypes.Role, "admin")

                    }
                }
            }
        }
    }
}
