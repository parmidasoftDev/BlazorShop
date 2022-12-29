﻿// <copyright file="TodoItemResponse.cs" author="Beniamin Jitca">
// Copyright (c) Beniamin Jitca. All rights reserved.
// </copyright>

namespace BlazorShop.Application.Responses
{
    /// <summary>
    /// A TodoItem response model.
    /// </summary>
    public class TodoItemResponse : IMapFrom<TodoItem>
    {
        /// <summary>
        /// The id of the item.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The id of the list.
        /// </summary>
        public int ListId { get; set; }

        /// <summary>
        /// The title of the item.
        /// </summary>
        public string? Title { get; set; }

        /// <summary>
        /// The note of the item.
        /// </summary>
        public string? Note { get; set; }

        /// <summary>
        /// The priority of the item.
        /// </summary>
        public TodoItemPriority Priority { get; set; }

        /// <summary>
        /// The state of the item.
        /// </summary>
        public TodoItemState State { get; set; }

        /// <summary>
        /// The status of the item.
        /// </summary>
        public bool Done { get; set; }

        /// <summary>
        /// The list.
        /// </summary>
        public TodoListResponse List { get; set; }

        /// <summary>
        /// Convert the entity (Data Access Layer) to model (Business Logic Layer).
        /// </summary>
        /// <param name="profile">The profile to use for the mapping operation.</param>
        public void Mapping(Profile profile)
        {
            profile.CreateMap<TodoItem, TodoItemResponse>()
                .ForMember(x => x.Id, opt => opt.MapFrom(s => s.Id))
                .ForMember(x => x.ListId, opt => opt.MapFrom(s => s.List.Id))
                .ForMember(x => x.Title, opt => opt.MapFrom(s => s.Title))
                .ForMember(x => x.Note, opt => opt.MapFrom(s => s.Note))
                .ForMember(x => x.Priority, opt => opt.MapFrom(s => s.Priority))
                .ForMember(x => x.State, opt => opt.MapFrom(s => s.State))
                .ForMember(x => x.Done, opt => opt.MapFrom(s => s.Done))
                .ForMember(x => x.List, opt => opt.MapFrom(s => s.List));
        }
    }
}
