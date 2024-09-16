﻿global using System.Diagnostics.CodeAnalysis;
global using System.Text.Json.Serialization;
global using Ardalis.GuardClauses;
global using Ardalis.Result;
global using Ardalis.Specification;
global using BookWorm.Catalog.Infrastructure.Ai;
global using BookWorm.Catalog.Infrastructure.Blob;
global using BookWorm.Catalog.Infrastructure.Data;
global using BookWorm.Core.SeedWork;
global using BookWorm.Core.SharedKernel;
global using BookWorm.ServiceDefaults;
global using BookWorm.Shared.ActivityScope;
global using BookWorm.Shared.Bus;
global using BookWorm.Shared.Converters;
global using BookWorm.Shared.Endpoints;
global using BookWorm.Shared.Exceptions;
global using BookWorm.Shared.Metrics;
global using BookWorm.Shared.Pipelines;
global using BookWorm.Shared.Versioning;
global using FluentValidation;
global using FluentValidation.Results;
global using MassTransit;
global using MediatR;
global using Microsoft.AspNetCore.Authorization;
global using Microsoft.AspNetCore.Http.HttpResults;
global using Microsoft.AspNetCore.Http.Json;
global using Microsoft.EntityFrameworkCore;
global using Microsoft.EntityFrameworkCore.Metadata.Builders;
global using Pgvector;
global using Pgvector.EntityFrameworkCore;
global using System.Diagnostics;
global using Azure;
global using Azure.Storage.Blobs;
global using Azure.Storage.Blobs.Models;
global using BookWorm.Constants;
global using Polly;
global using Polly.Registry;