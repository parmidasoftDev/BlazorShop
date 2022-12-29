﻿// <copyright file="DeleteUserCommandHandler.cs" author="Beniamin Jitca">
// Copyright (c) Beniamin Jitca. All rights reserved.
// </copyright>

namespace BlazorShop.Application.Handlers.Commands.UserHandler
{
    /// <summary>
    /// An implementation of the <see cref="IRequestHandler{DeleteUserCommand, RequestResponse}"/>.
    /// </summary>
    public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand, RequestResponse>
    {
        /// <summary>
        /// An instance of <see cref="IUserService"/>.
        /// </summary>
        private readonly IUserService _userService;

        /// <summary>
        /// An instance of <see cref="ILogger{DeleteUserCommandHandler}"/>.
        /// </summary>
        private readonly ILogger<DeleteUserCommandHandler> _logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteUserCommandHandler"/> class.
        /// </summary>
        /// <param name="userService">An instance of <see cref="IUserService"/>.</param>
        /// <param name="logger">An instance of <see cref="ILogger{DeleteUserCommandHandler}"/>.</param>
        /// <exception cref="ArgumentNullException">Thrown if there is no logger provided.</exception>
        public DeleteUserCommandHandler(IUserService userService, ILogger<DeleteUserCommandHandler> logger)
        {
            _userService = userService;
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        /// <summary>
        /// An implementation of the handler for <see cref="DeleteUserCommand"/>.
        /// </summary>
        /// <param name="request">The request object to handle.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A <see cref="Task{RequestResponse}"/>.</returns>
        public async Task<RequestResponse> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            RequestResponse? response;

            try
            {
                response = await _userService.DeleteUserAsync(request.Id);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ErrorsManager.DeleteUserCommand);
                response = RequestResponse.Failure($"{ErrorsManager.DeleteUserCommand}. {ex.Message}. {ex.InnerException?.Message}");
            }

            return response;
        }
    }
}
