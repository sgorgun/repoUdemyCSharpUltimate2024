﻿using System.Text.Json.Serialization;

namespace OpenStarwarsApi.DTOs;

public record Root(
    [property: JsonPropertyName("count")] int Count,
    [property: JsonPropertyName("next")] string Next,
    [property: JsonPropertyName("previous")] object Previous,
    [property: JsonPropertyName("results")] IReadOnlyList<Result> Results
);