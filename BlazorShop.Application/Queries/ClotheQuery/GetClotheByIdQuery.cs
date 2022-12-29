﻿// <copyright file="GetClotheByIdQuery.cs" author="Beniamin Jitca">
// Copyright (c) Beniamin Jitca. All rights reserved.
// </copyright>

namespace BlazorShop.Application.Queries.ClotheQuery
{
    /// <summary>
    /// A model to get the clothe.
    /// </summary>
    public class GetClotheByIdQuery : IRequest<Result<ClotheResponse>>
    {
        /// <summary>
        /// The id of the clothe.
        /// </summary>
        public int Id { get; set; }
    }
}
