﻿// <copyright file="_Imports.cs" author="Beniamin Jitca">
// Copyright (c) Beniamin Jitca. All rights reserved.
// </copyright>

global using Microsoft.AspNetCore.Identity;
global using Microsoft.EntityFrameworkCore;
global using Microsoft.Extensions.Configuration;
global using Microsoft.Extensions.DependencyInjection;
global using BlazorShop.Application.Common.Interfaces;
global using BlazorShop.Domain.Entities.Identity;
global using BlazorShop.Infrastructure.Persistence;
global using BlazorShop.Infrastructure.Services;
global using BlazorShop.Application.Common.Models;
global using System.Net;
global using System.Net.Mail;
global using System.Net.Mime;
global using BlazorShop.Domain.Entities;
global using BlazorShop.Infrastructure.Utils;
global using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
global using Microsoft.EntityFrameworkCore.ChangeTracking;
global using BlazorShop.Domain.Common;
global using BlazorShop.Infrastructure.Persistence.Configurations.Identity;
global using System.Reflection;
global using Microsoft.EntityFrameworkCore.Metadata.Builders;
global using AutoMapper;
global using AutoMapper.QueryableExtensions;
global using BlazorShop.Application.Commands.UserCommand;
global using BlazorShop.Application.Queries.UserQuery;
global using BlazorShop.Application.Responses;
global using BlazorShop.Application.Commands.AccountCommand;
global using Microsoft.IdentityModel.Tokens;
global using System.IdentityModel.Tokens.Jwt;
global using System.Security.Claims;
global using System.Text;
global using BlazorShop.Application.Commands.RoleCommand;
global using BlazorShop.Infrastructure.Persistence.Configurations;
global using BlazorShop.Application.Utils;
