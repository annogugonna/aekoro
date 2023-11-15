#!/bin/bash

function list_files_recursively() {
    local dir=$1

    # Loop through each file/directory in the given directory
    for file in "$dir"/*; do
        # Check if it's a directory
        if [ -d "$file" ]; then
            echo "Directory: $file"
            # Recursively list files in the subdirectory
            list_files_recursively "$file"
        elif [ -f "$file" ]; then
            # If it's a file, print its path
            echo "File: $file"
        fi
    done
}

# Start listing files from the current directory
echo "Listing files in the current directory and its subdirectories:"
list_files_recursively "$(pwd)"
