using Application.Abstractions.Data;
using Application.Abstractions.Messaging;
using Domain.Workouts;
using SharedKernel;

namespace Application.Workouts.AddExercises;

internal sealed class AddExercisesCommandHandler(
    IWorkoutRepository workoutRepository,
    IExerciseRepository exerciseRepository,
    IUnitOfWork unitOfWork)
    : ICommandHandler<AddExercisesCommand>
{
    public Task<Result> Handle(
        AddExercisesCommand request,
        CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
