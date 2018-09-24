const languageSwitcher = () => {
    const MLstrings = [
        {
            English: 'sudoku for all',
            Spanish: 'sudoku para todos',
            portuguese: 'sudoku para todos',
        },
        {
            English: 'login',
            Spanish: 'iniciar sesión',
            portuguese: 'iniciar sessão',
        },
        {
            English: 'logout',
            Spanish: 'cerrar sesión',
            portuguese: 'fechar Sessão',
        },
        {
            English: 'register',
            Spanish: 'regístrate',
            portuguese: 'registrar',
        },
    ];
    const mlCodes = [
        {
            code: 'en',
            name: 'English',
        },
        {
            code: 'es',
            name: 'Spanish',
        },
        {
            code: 'pt',
            name: 'Portuguese',
        },
    ];

    let mlrLangInUse;

    var mlr = function ({
        dropID = 'languagepicker',
        stringAttribute = 'data-text-text',
        chosenLang = 'Spanish',
        mLstrings = MLstrings,
        countryCodes = false,
        countryCodeData = [],
    } = {}) {
        const root = document.documentElement;

        var listOfLanguages = Object.keys(mLstrings[0]);
        mlrLangInUse = chosenLang;

        (function createMLDrop() {
            var mbPOCControlsLangDrop = document.getElementById(dropID);
            // Reset the menu
            mbPOCControlsLangDrop.innerHTML = '';
            // Now build the options
            listOfLanguages.forEach((lang, langidx) => {
                let HTMLoption = document.createElement('option');
                HTMLoption.value = lang;
                HTMLoption.textContent = lang;
                mbPOCControlsLangDrop.appendChild(HTMLoption);
                if (lang === chosenLang) {
                    mbPOCControlsLangDrop.value = lang;
                }
            });
            mbPOCControlsLangDrop.addEventListener('change', function (e) {
                mlrLangInUse =
                    mbPOCControlsLangDrop[mbPOCControlsLangDrop.selectedIndex].value;
                resolveAllMLStrings();
                // Here we update the 2-digit lang attribute if required
                if (countryCodes === true) {
                    if (!Array.isArray(countryCodeData) || !countryCodeData.length) {
                        console.warn('Cannot access strings for language codes');
                        return;
                    }
                    root.setAttribute('lang', updateCountryCodeOnHTML().code);
                }
            });
        })();

        function updateCountryCodeOnHTML() {
            return countryCodeData.find(
                this2Digit => this2Digit.name === mlrLangInUse
            );
        }

        function resolveAllMLStrings() {
            let stringsToBeResolved = document.querySelectorAll(
                `[${stringAttribute}]`
            );
            stringsToBeResolved.forEach(stringToBeResolved => {
                let originaltextContent = stringToBeResolved.textContent;
                let resolvedText = resolveMLString(originaltextContent, mLstrings);
                stringToBeResolved.textContent = resolvedText;
            });
        }
    };

    function resolveMLString(stringToBeResolved, mLstrings) {
        var matchingStringIndex = mLstrings.find(function (stringObj) {
            // Create an array of the objects values:
            let stringValues = Object.values(stringObj);
            // Now return if we can find that string anywhere in there
            return stringValues.includes(stringToBeResolved);
        });
        if (matchingStringIndex) {
            return matchingStringIndex[mlrLangInUse];
        } else {
            // If we don't have a match in our language strings, return the original
            return stringToBeResolved;
        }
    }

    mlr({
        dropID: 'languagepicker',
        stringAttribute: 'data-text',
        chosenLang: 'Spanish',
        mLstrings: MLstrings,
        countryCodes: true,
        countryCodeData: mlCodes,
    });
};

export default languageSwitcher;
