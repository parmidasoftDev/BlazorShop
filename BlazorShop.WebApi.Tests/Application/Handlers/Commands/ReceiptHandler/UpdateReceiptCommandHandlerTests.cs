﻿// <copyright file="UpdateReceiptCommandHandlerTests.cs" author="Beniamin Jitca">
// Copyright (c) Beniamin Jitca. All rights reserved.
// </copyright>

namespace BlazorShop.WebApi.Tests.Application.Handlers.Commands.ReceiptHandler
{
    /// <summary>
    /// Tests for <see cref="UpdateReceiptCommandHandler"/>.
    /// </summary>
    public class UpdateReceiptCommandHandlerTests
    {
        private readonly IApplicationDbContext _dbContext;
        private readonly ILogger<UpdateReceiptCommandHandlerTests> _logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateReceiptCommandHandlerTests"/> class.
        /// </summary>
        public UpdateReceiptCommandHandlerTests(IApplicationDbContext dbContext, ILogger<UpdateReceiptCommandHandlerTests> logger)
        {
            _dbContext = dbContext;
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        /// <summary>
        /// An implementation of the handler for <see cref="DeleteSubscriberCommand"/>.
        /// </summary>
        /// <param name="request">The request object to handle.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A <see cref="Task{RequestResponse}"/>.</returns>
        public async Task Handle(UpdateReceiptCommand request, CancellationToken cancellationToken)
        {
        }
    }
}
