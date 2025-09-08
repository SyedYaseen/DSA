use std::fs::File;
use std::io::{self, BufRead, BufReader};

fn main() {
    let path = "../CSES/tests/AdvancedTechniques/SubstringReversals2073/1.in";
    let file = File::open(path).expect("Failed to open input file");
    let mut reader = BufReader::new(file);

    let mut line = String::new();
    reader.read_line(&mut line).unwrap();
    let n: i64 = line.trim().parse().unwrap();

    println!("n = {}", n);
}
