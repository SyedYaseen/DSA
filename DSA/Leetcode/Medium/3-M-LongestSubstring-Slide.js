// Example 1:
// Input: s = "abcabcbb"
// Output: 3
// Explanation: The answer is "abc", with the length of 3.
// Example 2:

// Input: s = "bbbbb"
// Output: 1
// Explanation: The answer is "b", with the length of 1.
// Example 3:

// Input: s = "pwwkew"
// Output: 3
// Explanation: The answer is "wke", with the length of 3.
// Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.

let str = ["pwwkew", "abcabcbb", "dvdf", "bbbb", ""]
// str = ["abcabcbb"]
// str = ["bcdabedb"]
// str = ["pwwkew"]
// str = ["bbbb"]

// const sub = (s) => {
//   let result = 0
//   i = 0
//   j = 0
//   hash = []

//   while (j < s.length) {
//     let firstDuplicateIndex = hash.indexOf(s[j])
//     if (firstDuplicateIndex === -1) {
//       hash.push(s[j])
//       if (result < hash.length) result = hash.length
//       j += 1
//     } else {
//       hash = hash.slice(firstDuplicateIndex + 1)
//       i += 1
//     }
//   }
//   return result
// }

const sub = (s) => {
  let result = 0
  let h = []

  let i = 0
  let j = 0

  while (j < s.length) {
    let duplicateIndex = h.indexOf(s[j])

    if (duplicateIndex == -1) {
      h.push(s[j])
      if (h.length > result) result = h.length
      j++
    } else {
      h = h.slice(duplicateIndex + 1)
    }
  }

  return result
}

str.forEach((s) => console.log(sub(s)))
