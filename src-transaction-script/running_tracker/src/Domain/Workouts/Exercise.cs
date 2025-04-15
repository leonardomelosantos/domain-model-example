using SharedKernel;

namespace Domain.Workouts;

public sealed class Exercise : Entity
{
    public Exercise(
        Guid id,
        Guid workoutId,
        ExerciseType exerciseType,
        TargetType targetType,
        Distance? distance,
        TimeSpan? duration)
        : base(id)
    {
        WorkoutId = workoutId;
        ExerciseType = exerciseType;
        TargetType = targetType;
        Distance = distance;
        Duration = duration;
    }

    private Exercise()
    {
    }

    public Guid WorkoutId { get; private set; }

    public ExerciseType ExerciseType { get; private set; }

    public TargetType TargetType { get; private set; }

    public Distance? Distance { get; private set; }

    public TimeSpan? Duration { get; private set; }
}
