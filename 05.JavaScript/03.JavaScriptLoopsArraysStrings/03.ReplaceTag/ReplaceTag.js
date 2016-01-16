function solve(arr) {
    arr.forEach(function(line) {
        if (line.trim().slice(0, 3) === "<a ") {
            var newLine = line.replace("<a ", "[URL ").replace(">", "]").replace("</a>", "[/URL]");
            console.log(newLine);
        } else {
            console.log(line);
        }
    });
}

solve(['<ul>', '    <li>', '        <a href=http://softuni.bg>SoftUni</a>', '   </li>', '</ul>']);