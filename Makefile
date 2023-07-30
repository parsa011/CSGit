PROJECT= ./src/CSGit.Console

run :
	@dotnet run --project $(PROJECT)

build :
	@dotnet build

.PHONY : run
