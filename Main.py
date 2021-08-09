
def NonFactors(iNo):

    if iNo < 0:
        iNo = -iNo

    for x in range(2,iNo):
        if iNo%x != 0:
            print(x,end=" ")

def main():

    iValue = int(input("Enter Number\n"))

    NonFactors(iValue)

    print()

if __name__ == "__main__":

    main()