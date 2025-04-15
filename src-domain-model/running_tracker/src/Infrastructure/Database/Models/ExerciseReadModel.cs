﻿using Domain.Workouts;

namespace Infrastructure.Database.Models;

internal sealed class ExerciseReadModel
{
    public Guid Id { get; set; }

    public Guid WorkoutId { get; private set; }

    public ExerciseType ExerciseType { get; private set; }

    public TargetType TargetType { get; private set; }

    public decimal? Distance { get; private set; }

    public TimeSpan? Duration { get; private set; }
}
