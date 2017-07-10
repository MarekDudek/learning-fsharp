module Examples


// Character data

let string = "Hello World"
let verbatimString = @"I have a backslash: \ unescaped"
let multilineString = """I have "double-quotes"
and multiple lines"""

let bytearrayString = "I'm stored as a bytearray"B

let singleCharacter = 'c'

// Boolean

let boolean = true

// Numbers

//   Integers
let hexadecimalInteger = 0xFF
let octalInteger = 0o377
let binaryInteger = 0b11111111

//   Bytes
let unsignedByte = 127y
let unsignedByteNegative = -128y
let signedByteMin = 0uy
let signedByteMax = 255uy

//   16 byte integers
let integer16b = 34s
let unsignedInteger16b = 34us

//   32 byte integers
let integer32b = 34l
let unsignedInteger32b = 34ul

//   native integers
let nativeInteger = 34n 
let unsignedNativeInteger = 34un

//   64 byte integer
let integer64b = 34L
let unsignedInteger64b = 34UL

//   Floating-point
let singlePrecision = 3.0f
let doublePrecision = 3.0

//   Big
let bigInteger = 34I
// let bigDecimal = 34N !!! this doesn't work, NumericLiteralN required !!!


let main() =
  printfn "string: %A" string
  printfn "verbatim string: %A" verbatimString
  printfn "multi-line string: %A" multilineString
  printfn "single character: %A" singleCharacter
  printfn "boolean: %A" boolean
  printfn "hexadecimal integer %A" hexadecimalInteger
  printfn "octal integer %A" octalInteger
  printfn "binary integer %A" binaryInteger
  printfn "unsigned byte %A" unsignedByte
  printfn "unsigned byte negative %A" unsignedByteNegative
  printfn "signed byte (min) %A" signedByteMin
  printfn "signed byte (max) %A" signedByteMax

main()
