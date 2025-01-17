﻿using ImagXAPI.Contracts;
using ImagXAPI.Data;
using ImagXAPI.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImagXAPI.Repositories
{
    public class ResetTokenRepository : GenericRepository<ResetToken>, IResetTokenRepository
    {
        private readonly AppDbContext _context;

        public ResetTokenRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async  Task<ResetToken> GetByToken(string token)
        {
            return  await _context.ResetTokens.FirstOrDefaultAsync(x => x.EmailToken == token);
        }
    }
}
