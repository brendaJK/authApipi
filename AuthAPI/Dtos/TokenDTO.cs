﻿namespace AuthAPI.Dtos
{
    public class TokenDTO
    {
        public string RefreshToken { get; set; } = null!;
        public string Token { get; set; } = null!;
        public string Email { get; set; } = null!;

    }
}
