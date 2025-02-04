# Docker commands

## Build the Docker image

docker build -t winecellarapi .

## Run the Docker container

docker run -d -p 8080:80 winecellarapi

---

# Git Commands

## Create branch and push

git init
git commit -m "first commit"
git branch -M main
git remote add origin https://github.com/tBaronDar/wine-cellar-api.git
git push -u origin main

---

# EF commands

## Create & upadte migration

dotnet ef migrations add InitialCreate
dotnet ef database update

## Delete & update migration

dotnet ef database drop
dotnet ef database update
