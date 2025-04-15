using SharedKernel;

namespace Domain.Workouts;

public sealed class Workout : Entity
{
    public Workout(Guid id, Guid userId, string name)
        : base(id)
    {
        UserId = userId;
        Name = name;
    }

    private Workout()
    {
    }

    public Guid UserId { get; private set; }

    public string Name { get; private set; }

    public List<Exercise> Exercises { get; init; } = new();
}
