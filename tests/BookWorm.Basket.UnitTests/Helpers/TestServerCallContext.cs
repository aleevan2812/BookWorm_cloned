﻿namespace BookWorm.Basket.UnitTests.Helpers;

public sealed class TestServerCallContext(
    Metadata? requestHeaders = null,
    CancellationToken cancellationToken = default,
    DateTime? deadline = null,
    Metadata? responseTrailers = null,
    WriteOptions? writeOptions = null,
    AuthContext? authContext = null) : ServerCallContext
{
    protected override string MethodCore => "test";

    protected override string HostCore => "localhost";

    protected override string PeerCore => "127.0.0.1";

    protected override DateTime DeadlineCore { get; } = deadline ?? DateTime.UtcNow.AddMinutes(5);

    protected override Metadata RequestHeadersCore { get; } = requestHeaders ?? [];

    protected override CancellationToken CancellationTokenCore => cancellationToken;

    protected override Metadata ResponseTrailersCore { get; } = responseTrailers ?? [];

    protected override Status StatusCore { get; set; }

    private readonly Dictionary<object, object> _userState = new();

    protected override WriteOptions? WriteOptionsCore
    {
        get => writeOptions;
        set { }
    }

    protected override AuthContext AuthContextCore { get; } = authContext ?? new AuthContext("anonymous", new());

    protected override IDictionary<object, object> UserStateCore => _userState;

    internal void SetUserState(object key, object value)
        => _userState[key] = value;

    protected override ContextPropagationToken CreatePropagationTokenCore(ContextPropagationOptions? options)
    {
        throw new NotImplementedException();
    }

    protected override Task WriteResponseHeadersAsyncCore(Metadata responseHeaders)
    {
        return Task.CompletedTask;
    }

    public static TestServerCallContext Create(Metadata? requestHeaders = null, CancellationToken cancellationToken = default)
    {
        return new(requestHeaders: [], cancellationToken);
    }
}