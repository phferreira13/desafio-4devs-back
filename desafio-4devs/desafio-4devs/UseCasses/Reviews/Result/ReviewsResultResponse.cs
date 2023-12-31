﻿using desafio_4devs_domain.DTOs.Reviews;
using desafio_4devs_domain.Models;

namespace desafio_4devs.UseCasses.Reviews.Result
{
    public class ReviewsResultResponse
    {
        public required IEnumerable<ReviewResultDto> ReviewResults { get; set; }
    }
}
