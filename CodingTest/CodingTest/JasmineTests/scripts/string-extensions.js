String.prototype.capitalise = function () {
  if (this.length > 0) {
    var firstChar = this.charAt(0);
    return firstChar.toUpperCase() + this.substr(1);
  } else {
    return '';
  }
}

String.prototype.camelCaseToSpineCase = function() {
  if (this.length > 0) {
    var opString = '';
    for (var i = 0; i < this.length; i++) {
      var thisChar = this[i];
      if (thisChar === '-') {
        // Skip existing hyphen
      } else if (thisChar === ' ') {
        // Convert space to hyphen
        opString += "-";
      } else if (thisChar.match(/[A-Z]/)) {
        // If last char of output string is a hyphen, just convert the char to lowercase.
        // Otherwise convert uppercase char to hyphen followed by the lowercase equivalent
        if (opString.substr(opString.length - 1) === '-') {
          opString += thisChar.toLowerCase();
        } else {
          opString += "-" + thisChar.toLowerCase();
        }
      } else {
        // Copy all other characters as they are
        opString += thisChar;
      }
    }
    return opString;
  } else {
    return '';
  }
}

String.prototype.spineCaseToCamelCase = function () {
  var trimmed = this.trim();
  if (trimmed.length > 0) {
    var opString = '';
    var capitaliseNext = false;
    
    for (var i = 0; i < trimmed.length; i++) {
      var thisChar = trimmed[i];
      if ((thisChar === '-') || (thisChar === ' ')) {
        // Skip the character and capitalise the next letter
        capitaliseNext = true;
      } else {
        if (thisChar.match(/[a-z]/)) {
          // If the next character is lowercase and we have to capitalise, capitalise it. Otherwise copy as is.
          if (capitaliseNext === true) {
            opString += thisChar.toUpperCase();
          } else {
            opString += thisChar;
          }
        } else if (thisChar.match(/[A-Z]/)) {
          // If the next character is uppercase, copy as is.
          opString += thisChar;
        } else {
          // Copy all other characters as is.
          opString += thisChar;
        }
        capitaliseNext = false;
      }
    }
    return opString;
  } else {
    return '';
  }
}

String.prototype.format = function() {
  var args = Array.from(arguments);
  var opString;
  if (this.length > 0) {
    if (args.length === 0) {
      opString = this.toString();
    } else {
      opString = this;
      for (var i = 0; i < args.length; i++) {
        var param = '{' + i.toString() + '}';
        var replacement = args[i];
        opString = opString.replace(param, replacement);
      }
    }
    return opString;
  } else {
    return '';
  }
}