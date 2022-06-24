﻿// <copyright file="DeleteAllCartsCommand.cs" company="Beniamin Jitca">
// Copyright (c) Beniamin Jitca. All rights reserved.
// </copyright>

namespace BlazorShop.Application.Commands.CartCommand
{
    /// <summary>
    /// A model to delete all the carts.
    /// </summary>
    public class DeleteAllCartsCommand : IRequest<RequestResponse>
    {
        /// <summary>
        /// .
        /// </summary>
        public int UserId { get; set; }
    }
}
