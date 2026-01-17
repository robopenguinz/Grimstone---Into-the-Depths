# Set text files to auto-handle line endings
* text=auto

# Treat Unity files correctly
*.cs text eol=lf
*.shader text eol=lf
*.txt text
*.json text

# Binary files (don’t touch)
*.png binary
*.jpg binary
*.fbx binary
*.unity binary
*.prefab binary

# Ignore Library, Temp, Build, and Logs (don’t commit)
[Ll]ibrary/** binary
[Tt]emp/** binary
[Bb]uild/** binary
[Bb]uilds/** binary
[Ll]ogs/** binary
UserSettings/** binary
