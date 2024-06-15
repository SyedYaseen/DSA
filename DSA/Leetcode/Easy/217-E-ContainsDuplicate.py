from typing import List


# def containsDuplicate(nums: List[int]) -> bool:
#     return len(nums) != len(set(nums))


def containsDuplicate(nums: List[int]) -> bool:
    s = set()
    for i in nums:
        if i in s:
            return False
        s.add(i)

    return True


print(containsDuplicate([1, 1, 1, 3, 3, 4, 3, 2, 4, 2]))
print(containsDuplicate([1, 2, 3, 4]))
