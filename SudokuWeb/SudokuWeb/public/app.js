!function i(u, s, a) {
    function c(t, e) {
        if (!s[t]) {
            if (!u[t]) {
                var n = "function" == typeof require && require;
                if (!e && n) return n(t, !0);
                if (l) return l(t, !0);
                var r = new Error("Cannot find module '" + t + "'");
                throw r.code = "MODULE_NOT_FOUND", r
            }
            var o = s[t] = {
                exports: {}
            }; u[t][0].call(o.exports, function (e) {
                return c(u[t][1][e] || e)
            },
                o,
                o.exports, i, u, s, a)
        }
        return s[t].exports
    }
    for (var l = "function" == typeof require && require, e = 0; e < a.length; e++)c(a[e]);
    return c
}
    ({
        1: [function (e, t, n) {
            "use strict";
            Object.defineProperty(n, "__esModule", { value: !0 });
            n.default = function () {
                var h = [{
                    Spanish: "Sudoku para Todos",
                    English: "Sudoku For All",
                    portuguese: "Sudoku para Todos"
                },
                {
                    Spanish: "Iniciar Sesión",
                    English: "Login",
                    portuguese: "Iniciar Sessão"
                },
                {
                    Spanish: "Cerrar Sesión",
                    English: "Logout",
                    portuguese: "Fechar Sessão"
                },
                {
                    Spanish: "Regístrate",
                    English: "Register",
                    portuguese: "Registrar"
                }],
                    m = void 0; !function () {
                        var r, e = 0 < arguments.length && void 0 !== arguments[0] ? arguments[0] : {},
                            t = e.dropID,
                            n = void 0 === t ? "languagepicker" : t,
                            o = e.stringAttribute,
                            i = void 0 === o ? "data-text-text" : o,
                            u = e.chosenLang,
                            s = void 0 === u ? "Spanish" : u,
                            a = e.mLstrings,
                            c = void 0 === a ? h : a,
                            l = e.countryCodes, d = void 0 !== l && l, g = e.countryCodeData, f = void 0 === g ? [] : g, p = document.documentElement, v = Object.keys(c[0]); m = s, (r = document.getElementById(n)).innerHTML = "", v.forEach(function (e, t) { var n = document.createElement("option"); n.value = e, n.textContent = e, r.appendChild(n), e === s && (r.value = e) }), r.addEventListener("change", function (e) { if (m = r[r.selectedIndex].value, document.querySelectorAll("[" + i + "]").forEach(function (e) { var n, t, r = e.textContent, o = (n = r, (t = c.find(function (e) { var t = Object.values(e); return t.includes(n) })) ? t[m] : n); e.textContent = o }), !0 === d) { if (!Array.isArray(f) || !f.length) return void console.warn("Cannot access strings for language codes"); p.setAttribute("lang", f.find(function (e) { return e.name === m }).code) } })
                    }
                        ({
                            dropID: "languagepicker",
                            stringAttribute: "data-text",
                            chosenLang: "Spanish",
                            mLstrings: h,
                            countryCodes: !0,
                            countryCodeData: [{
                                code: "es",
                                name: "Spanish"
                            },
                            {
                                code: "en",
                                name: "English"
                            },
                            {
                                code: "pt",
                                name: "Portuguese"
                            }]
                        })
            }
        },
        {}],
        2: [function (e, t, n) {
            "use strict";
            r(e("./toggleMenu"));
            function r(e) {
                return e && e.__esModule ? e : { default: e }
            }
            (0, r(e("./languageSwitcher")).default)()
        },
        {
            "./languageSwitcher": 1, "./toggleMenu": 3
        }],
        3: [function (e, t, n) {
            "use strict";
            Object.defineProperty(n, "__esModule",
                {
                    value: !0
                });
            n.default = function () {
                var t = document.querySelector("#hamburguer-btn"),
                    n = document.querySelector("#menu-list"),
                    r = document.querySelector("#language-list"),
                    o = (n.querySelectorAll(".menu-list-item > .anchor"),
                        function () {
                            t.classList.remove("-open"),
                                n.classList.remove("-open"),
                                r.classList.remove("-open")
                        });
                t.addEventListener("click", function (e) {
                    e.preventDefault(),
                        t.classList.toggle("-open"),
                        n.classList.toggle("-open"),
                        r.classList.toggle("-open")
                }),
                    n.addEventListener("click", function (e) {
                        "A" === e.target.nodeName && o()
                    }),
                    r.addEventListener("click", function (e) {
                        "A" === e.target.nodeName && o()
                    })
            }
        }, {}]
    }, {}, [2]);
//# sourceMappingURL=app.js.map
