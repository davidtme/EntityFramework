﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.Data.Entity.FunctionalTests;
using Microsoft.Data.Entity.Relational.FunctionalTests;
using Xunit;

namespace Microsoft.Data.Entity.SqlServer.FunctionalTests
{
    public class NullSemanticsQuerySqlServerTest : NullSemanticsQueryTestBase<SqlServerTestStore, NullSemanticsQuerySqlServerFixture>
    {
        public NullSemanticsQuerySqlServerTest(NullSemanticsQuerySqlServerFixture fixture)
            : base(fixture)
        {
        }

        public override void Compare_bool_with_bool_equal()
        {
            base.Compare_bool_with_bool_equal();

            Assert.Equal(
                @"SELECT [e].[Id]
FROM [NullSemanticsEntity1] AS [e]
WHERE [e].[BoolA] = [e].[BoolB]

SELECT [e].[Id]
FROM [NullSemanticsEntity1] AS [e]
WHERE [e].[BoolA] = [e].[NullableBoolB]

SELECT [e].[Id]
FROM [NullSemanticsEntity1] AS [e]
WHERE [e].[NullableBoolA] = [e].[BoolB]

SELECT [e].[Id]
FROM [NullSemanticsEntity1] AS [e]
WHERE ([e].[NullableBoolA] = [e].[NullableBoolB]) OR ([e].[NullableBoolA] IS NULL AND [e].[NullableBoolB] IS NULL)",
                Sql);
        }

        public override void Compare_negated_bool_with_bool_equal()
        {
            base.Compare_negated_bool_with_bool_equal();

            Assert.Equal(
                @"SELECT [e].[Id]
FROM [NullSemanticsEntity1] AS [e]
WHERE [e].[BoolA] <> [e].[BoolB]

SELECT [e].[Id]
FROM [NullSemanticsEntity1] AS [e]
WHERE ([e].[BoolA] <> [e].[NullableBoolB]) AND [e].[NullableBoolB] IS NOT NULL

SELECT [e].[Id]
FROM [NullSemanticsEntity1] AS [e]
WHERE ([e].[NullableBoolA] <> [e].[BoolB]) AND [e].[NullableBoolA] IS NOT NULL

SELECT [e].[Id]
FROM [NullSemanticsEntity1] AS [e]
WHERE (([e].[NullableBoolA] <> [e].[NullableBoolB]) AND [e].[NullableBoolA] IS NOT NULL AND [e].[NullableBoolB] IS NOT NULL) OR ([e].[NullableBoolA] IS NULL AND [e].[NullableBoolB] IS NULL)",
                Sql);
        }

        public override void Compare_bool_with_negated_bool_equal()
        {
            base.Compare_bool_with_negated_bool_equal();

            Assert.Equal(
                @"SELECT [e].[Id]
FROM [NullSemanticsEntity1] AS [e]
WHERE [e].[BoolA] <> [e].[BoolB]

SELECT [e].[Id]
FROM [NullSemanticsEntity1] AS [e]
WHERE ([e].[BoolA] <> [e].[NullableBoolB]) AND [e].[NullableBoolB] IS NOT NULL

SELECT [e].[Id]
FROM [NullSemanticsEntity1] AS [e]
WHERE ([e].[NullableBoolA] <> [e].[BoolB]) AND [e].[NullableBoolA] IS NOT NULL

SELECT [e].[Id]
FROM [NullSemanticsEntity1] AS [e]
WHERE (([e].[NullableBoolA] <> [e].[NullableBoolB]) AND [e].[NullableBoolA] IS NOT NULL AND [e].[NullableBoolB] IS NOT NULL) OR ([e].[NullableBoolA] IS NULL AND [e].[NullableBoolB] IS NULL)",
                Sql);
        }

        public override void Compare_negated_bool_with_negated_bool_equal()
        {
            base.Compare_negated_bool_with_negated_bool_equal();

            Assert.Equal(
                @"SELECT [e].[Id]
FROM [NullSemanticsEntity1] AS [e]
WHERE [e].[BoolA] = [e].[BoolB]

SELECT [e].[Id]
FROM [NullSemanticsEntity1] AS [e]
WHERE ([e].[BoolA] = [e].[NullableBoolB]) AND [e].[NullableBoolB] IS NOT NULL

SELECT [e].[Id]
FROM [NullSemanticsEntity1] AS [e]
WHERE ([e].[NullableBoolA] = [e].[BoolB]) AND [e].[NullableBoolA] IS NOT NULL

SELECT [e].[Id]
FROM [NullSemanticsEntity1] AS [e]
WHERE (([e].[NullableBoolA] = [e].[NullableBoolB]) AND [e].[NullableBoolA] IS NOT NULL AND [e].[NullableBoolB] IS NOT NULL) OR ([e].[NullableBoolA] IS NULL AND [e].[NullableBoolB] IS NULL)",
                Sql);
        }

        public override void Compare_bool_with_bool_equal_negated()
        {
            base.Compare_bool_with_bool_equal_negated();

            Assert.Equal(
                @"SELECT [e].[Id]
FROM [NullSemanticsEntity1] AS [e]
WHERE [e].[BoolA] <> [e].[BoolB]

SELECT [e].[Id]
FROM [NullSemanticsEntity1] AS [e]
WHERE ([e].[BoolA] <> [e].[NullableBoolB]) OR [e].[NullableBoolB] IS NULL

SELECT [e].[Id]
FROM [NullSemanticsEntity1] AS [e]
WHERE ([e].[NullableBoolA] <> [e].[BoolB]) OR [e].[NullableBoolA] IS NULL

SELECT [e].[Id]
FROM [NullSemanticsEntity1] AS [e]
WHERE (([e].[NullableBoolA] <> [e].[NullableBoolB]) OR [e].[NullableBoolA] IS NULL OR [e].[NullableBoolB] IS NULL) AND ([e].[NullableBoolA] IS NOT NULL OR [e].[NullableBoolB] IS NOT NULL)",
                Sql);
        }

        public override void Compare_negated_bool_with_bool_equal_negated()
        {
            base.Compare_negated_bool_with_bool_equal_negated();

            Assert.Equal(
                @"SELECT [e].[Id]
FROM [NullSemanticsEntity1] AS [e]
WHERE [e].[BoolA] = [e].[BoolB]

SELECT [e].[Id]
FROM [NullSemanticsEntity1] AS [e]
WHERE ([e].[BoolA] = [e].[NullableBoolB]) OR [e].[NullableBoolB] IS NULL

SELECT [e].[Id]
FROM [NullSemanticsEntity1] AS [e]
WHERE ([e].[NullableBoolA] = [e].[BoolB]) OR [e].[NullableBoolA] IS NULL

SELECT [e].[Id]
FROM [NullSemanticsEntity1] AS [e]
WHERE (([e].[NullableBoolA] = [e].[NullableBoolB]) OR [e].[NullableBoolA] IS NULL OR [e].[NullableBoolB] IS NULL) AND ([e].[NullableBoolA] IS NOT NULL OR [e].[NullableBoolB] IS NOT NULL)",
                Sql);
        }

        public override void Compare_bool_with_negated_bool_equal_negated()
        {
            base.Compare_bool_with_negated_bool_equal_negated();

            Assert.Equal(
                @"SELECT [e].[Id]
FROM [NullSemanticsEntity1] AS [e]
WHERE [e].[BoolA] = [e].[BoolB]

SELECT [e].[Id]
FROM [NullSemanticsEntity1] AS [e]
WHERE ([e].[BoolA] = [e].[NullableBoolB]) OR [e].[NullableBoolB] IS NULL

SELECT [e].[Id]
FROM [NullSemanticsEntity1] AS [e]
WHERE ([e].[NullableBoolA] = [e].[BoolB]) OR [e].[NullableBoolA] IS NULL

SELECT [e].[Id]
FROM [NullSemanticsEntity1] AS [e]
WHERE (([e].[NullableBoolA] = [e].[NullableBoolB]) OR [e].[NullableBoolA] IS NULL OR [e].[NullableBoolB] IS NULL) AND ([e].[NullableBoolA] IS NOT NULL OR [e].[NullableBoolB] IS NOT NULL)",
                Sql);
        }

        public override void Compare_negated_bool_with_negated_bool_equal_negated()
        {
            base.Compare_negated_bool_with_negated_bool_equal_negated();

            Assert.Equal(
                @"SELECT [e].[Id]
FROM [NullSemanticsEntity1] AS [e]
WHERE [e].[BoolA] <> [e].[BoolB]

SELECT [e].[Id]
FROM [NullSemanticsEntity1] AS [e]
WHERE ([e].[BoolA] <> [e].[NullableBoolB]) OR [e].[NullableBoolB] IS NULL

SELECT [e].[Id]
FROM [NullSemanticsEntity1] AS [e]
WHERE ([e].[NullableBoolA] <> [e].[BoolB]) OR [e].[NullableBoolA] IS NULL

SELECT [e].[Id]
FROM [NullSemanticsEntity1] AS [e]
WHERE (([e].[NullableBoolA] <> [e].[NullableBoolB]) OR [e].[NullableBoolA] IS NULL OR [e].[NullableBoolB] IS NULL) AND ([e].[NullableBoolA] IS NOT NULL OR [e].[NullableBoolB] IS NOT NULL)",
                Sql);
        }

        public override void Compare_bool_with_bool_not_equal()
        {
            base.Compare_bool_with_bool_not_equal();

            Assert.Equal(
                @"SELECT [e].[Id]
FROM [NullSemanticsEntity1] AS [e]
WHERE [e].[BoolA] <> [e].[BoolB]

SELECT [e].[Id]
FROM [NullSemanticsEntity1] AS [e]
WHERE ([e].[BoolA] <> [e].[NullableBoolB]) OR [e].[NullableBoolB] IS NULL

SELECT [e].[Id]
FROM [NullSemanticsEntity1] AS [e]
WHERE ([e].[NullableBoolA] <> [e].[BoolB]) OR [e].[NullableBoolA] IS NULL

SELECT [e].[Id]
FROM [NullSemanticsEntity1] AS [e]
WHERE (([e].[NullableBoolA] <> [e].[NullableBoolB]) OR [e].[NullableBoolA] IS NULL OR [e].[NullableBoolB] IS NULL) AND ([e].[NullableBoolA] IS NOT NULL OR [e].[NullableBoolB] IS NOT NULL)",
                Sql);
        }

        public override void Compare_negated_bool_with_bool_not_equal()
        {
            base.Compare_negated_bool_with_bool_not_equal();

            Assert.Equal(
                @"SELECT [e].[Id]
FROM [NullSemanticsEntity1] AS [e]
WHERE [e].[BoolA] = [e].[BoolB]

SELECT [e].[Id]
FROM [NullSemanticsEntity1] AS [e]
WHERE ([e].[BoolA] = [e].[NullableBoolB]) OR [e].[NullableBoolB] IS NULL

SELECT [e].[Id]
FROM [NullSemanticsEntity1] AS [e]
WHERE ([e].[NullableBoolA] = [e].[BoolB]) OR [e].[NullableBoolA] IS NULL

SELECT [e].[Id]
FROM [NullSemanticsEntity1] AS [e]
WHERE (([e].[NullableBoolA] = [e].[NullableBoolB]) OR [e].[NullableBoolA] IS NULL OR [e].[NullableBoolB] IS NULL) AND ([e].[NullableBoolA] IS NOT NULL OR [e].[NullableBoolB] IS NOT NULL)",
                Sql);
        }

        public override void Compare_bool_with_negated_bool_not_equal()
        {
            base.Compare_bool_with_negated_bool_not_equal();

            Assert.Equal(
                @"SELECT [e].[Id]
FROM [NullSemanticsEntity1] AS [e]
WHERE [e].[BoolA] = [e].[BoolB]

SELECT [e].[Id]
FROM [NullSemanticsEntity1] AS [e]
WHERE ([e].[BoolA] = [e].[NullableBoolB]) OR [e].[NullableBoolB] IS NULL

SELECT [e].[Id]
FROM [NullSemanticsEntity1] AS [e]
WHERE ([e].[NullableBoolA] = [e].[BoolB]) OR [e].[NullableBoolA] IS NULL

SELECT [e].[Id]
FROM [NullSemanticsEntity1] AS [e]
WHERE (([e].[NullableBoolA] = [e].[NullableBoolB]) OR [e].[NullableBoolA] IS NULL OR [e].[NullableBoolB] IS NULL) AND ([e].[NullableBoolA] IS NOT NULL OR [e].[NullableBoolB] IS NOT NULL)",
                Sql);
        }

        public override void Compare_negated_bool_with_negated_bool_not_equal()
        {
            base.Compare_negated_bool_with_negated_bool_not_equal();

            Assert.Equal(
                @"SELECT [e].[Id]
FROM [NullSemanticsEntity1] AS [e]
WHERE [e].[BoolA] <> [e].[BoolB]

SELECT [e].[Id]
FROM [NullSemanticsEntity1] AS [e]
WHERE ([e].[BoolA] <> [e].[NullableBoolB]) OR [e].[NullableBoolB] IS NULL

SELECT [e].[Id]
FROM [NullSemanticsEntity1] AS [e]
WHERE ([e].[NullableBoolA] <> [e].[BoolB]) OR [e].[NullableBoolA] IS NULL

SELECT [e].[Id]
FROM [NullSemanticsEntity1] AS [e]
WHERE (([e].[NullableBoolA] <> [e].[NullableBoolB]) OR [e].[NullableBoolA] IS NULL OR [e].[NullableBoolB] IS NULL) AND ([e].[NullableBoolA] IS NOT NULL OR [e].[NullableBoolB] IS NOT NULL)",
                Sql);
        }

        public override void Compare_bool_with_bool_not_equal_negated()
        {
            base.Compare_bool_with_bool_not_equal_negated();

            Assert.Equal(
                @"SELECT [e].[Id]
FROM [NullSemanticsEntity1] AS [e]
WHERE [e].[BoolA] = [e].[BoolB]

SELECT [e].[Id]
FROM [NullSemanticsEntity1] AS [e]
WHERE [e].[BoolA] = [e].[NullableBoolB]

SELECT [e].[Id]
FROM [NullSemanticsEntity1] AS [e]
WHERE [e].[NullableBoolA] = [e].[BoolB]

SELECT [e].[Id]
FROM [NullSemanticsEntity1] AS [e]
WHERE ([e].[NullableBoolA] = [e].[NullableBoolB]) OR ([e].[NullableBoolA] IS NULL AND [e].[NullableBoolB] IS NULL)",
                Sql);
        }

        public override void Compare_negated_bool_with_bool_not_equal_negated()
        {
            base.Compare_negated_bool_with_bool_not_equal_negated();

            Assert.Equal(
                @"SELECT [e].[Id]
FROM [NullSemanticsEntity1] AS [e]
WHERE [e].[BoolA] <> [e].[BoolB]

SELECT [e].[Id]
FROM [NullSemanticsEntity1] AS [e]
WHERE ([e].[BoolA] <> [e].[NullableBoolB]) AND [e].[NullableBoolB] IS NOT NULL

SELECT [e].[Id]
FROM [NullSemanticsEntity1] AS [e]
WHERE ([e].[NullableBoolA] <> [e].[BoolB]) AND [e].[NullableBoolA] IS NOT NULL

SELECT [e].[Id]
FROM [NullSemanticsEntity1] AS [e]
WHERE (([e].[NullableBoolA] <> [e].[NullableBoolB]) AND [e].[NullableBoolA] IS NOT NULL AND [e].[NullableBoolB] IS NOT NULL) OR ([e].[NullableBoolA] IS NULL AND [e].[NullableBoolB] IS NULL)",
                Sql);
        }

        public override void Compare_bool_with_negated_bool_not_equal_negated()
        {
            base.Compare_bool_with_negated_bool_not_equal_negated();

            Assert.Equal(
                @"SELECT [e].[Id]
FROM [NullSemanticsEntity1] AS [e]
WHERE [e].[BoolA] <> [e].[BoolB]

SELECT [e].[Id]
FROM [NullSemanticsEntity1] AS [e]
WHERE ([e].[BoolA] <> [e].[NullableBoolB]) AND [e].[NullableBoolB] IS NOT NULL

SELECT [e].[Id]
FROM [NullSemanticsEntity1] AS [e]
WHERE ([e].[NullableBoolA] <> [e].[BoolB]) AND [e].[NullableBoolA] IS NOT NULL

SELECT [e].[Id]
FROM [NullSemanticsEntity1] AS [e]
WHERE (([e].[NullableBoolA] <> [e].[NullableBoolB]) AND [e].[NullableBoolA] IS NOT NULL AND [e].[NullableBoolB] IS NOT NULL) OR ([e].[NullableBoolA] IS NULL AND [e].[NullableBoolB] IS NULL)",
                Sql);
        }

        public override void Compare_negated_bool_with_negated_bool_not_equal_negated()
        {
            base.Compare_negated_bool_with_negated_bool_not_equal_negated();

            Assert.Equal(
                @"SELECT [e].[Id]
FROM [NullSemanticsEntity1] AS [e]
WHERE [e].[BoolA] = [e].[BoolB]

SELECT [e].[Id]
FROM [NullSemanticsEntity1] AS [e]
WHERE ([e].[BoolA] = [e].[NullableBoolB]) AND [e].[NullableBoolB] IS NOT NULL

SELECT [e].[Id]
FROM [NullSemanticsEntity1] AS [e]
WHERE ([e].[NullableBoolA] = [e].[BoolB]) AND [e].[NullableBoolA] IS NOT NULL

SELECT [e].[Id]
FROM [NullSemanticsEntity1] AS [e]
WHERE (([e].[NullableBoolA] = [e].[NullableBoolB]) AND [e].[NullableBoolA] IS NOT NULL AND [e].[NullableBoolB] IS NOT NULL) OR ([e].[NullableBoolA] IS NULL AND [e].[NullableBoolB] IS NULL)",
                Sql);
        }

        public override void Compare_complex_equal_equal_equal()
        {
            base.Compare_complex_equal_equal_equal();

            Assert.Equal(
                @"SELECT [e].[Id]
FROM [NullSemanticsEntity1] AS [e]
WHERE CASE WHEN (
    [e].[BoolA] = [e].[BoolB]) THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END = CASE WHEN (
    [e].[IntA] = [e].[IntB]) THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END

SELECT [e].[Id]
FROM [NullSemanticsEntity1] AS [e]
WHERE CASE WHEN (
    [e].[NullableBoolA] = [e].[BoolB]) THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END = CASE WHEN (
    [e].[IntA] = [e].[NullableIntB]) THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END

SELECT [e].[Id]
FROM [NullSemanticsEntity1] AS [e]
WHERE CASE WHEN (
    ([e].[NullableBoolA] = [e].[NullableBoolB]) OR ([e].[NullableBoolA] IS NULL AND [e].[NullableBoolB] IS NULL)) THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END = CASE WHEN (
    ([e].[NullableIntA] = [e].[NullableIntB]) OR ([e].[NullableIntA] IS NULL AND [e].[NullableIntB] IS NULL)) THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END",
                Sql);
        }

        public override void Compare_complex_equal_not_equal_equal()
        {
            base.Compare_complex_equal_not_equal_equal();

            Assert.Equal(
                @"SELECT [e].[Id]
FROM [NullSemanticsEntity1] AS [e]
WHERE CASE WHEN (
    [e].[BoolA] = [e].[BoolB]) THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END <> CASE WHEN (
    [e].[IntA] = [e].[IntB]) THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END

SELECT [e].[Id]
FROM [NullSemanticsEntity1] AS [e]
WHERE CASE WHEN (
    [e].[NullableBoolA] = [e].[BoolB]) THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END <> CASE WHEN (
    [e].[IntA] = [e].[NullableIntB]) THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END

SELECT [e].[Id]
FROM [NullSemanticsEntity1] AS [e]
WHERE CASE WHEN (
    ([e].[NullableBoolA] = [e].[NullableBoolB]) OR ([e].[NullableBoolA] IS NULL AND [e].[NullableBoolB] IS NULL)) THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END <> CASE WHEN (
    ([e].[NullableIntA] = [e].[NullableIntB]) OR ([e].[NullableIntA] IS NULL AND [e].[NullableIntB] IS NULL)) THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END",
                Sql);
        }

        public override void Compare_complex_not_equal_equal_equal()
        {
            base.Compare_complex_not_equal_equal_equal();

            Assert.Equal(
                @"SELECT [e].[Id]
FROM [NullSemanticsEntity1] AS [e]
WHERE CASE WHEN (
    [e].[BoolA] <> [e].[BoolB]) THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END = CASE WHEN (
    [e].[IntA] = [e].[IntB]) THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END

SELECT [e].[Id]
FROM [NullSemanticsEntity1] AS [e]
WHERE CASE WHEN (
    ([e].[NullableBoolA] <> [e].[BoolB]) OR [e].[NullableBoolA] IS NULL) THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END = CASE WHEN (
    ([e].[IntA] = [e].[NullableIntB]) AND [e].[NullableIntB] IS NOT NULL) THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END

SELECT [e].[Id]
FROM [NullSemanticsEntity1] AS [e]
WHERE CASE WHEN (
    (([e].[NullableBoolA] <> [e].[NullableBoolB]) OR [e].[NullableBoolA] IS NULL OR [e].[NullableBoolB] IS NULL) AND ([e].[NullableBoolA] IS NOT NULL OR [e].[NullableBoolB] IS NOT NULL)) THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END = CASE WHEN (
    (([e].[NullableIntA] = [e].[NullableIntB]) AND [e].[NullableIntA] IS NOT NULL AND [e].[NullableIntB] IS NOT NULL) OR ([e].[NullableIntA] IS NULL AND [e].[NullableIntB] IS NULL)) THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END",
                Sql);
        }

        public override void Compare_complex_not_equal_not_equal_equal()
        {
            base.Compare_complex_not_equal_not_equal_equal();

            Assert.Equal(
                @"SELECT [e].[Id]
FROM [NullSemanticsEntity1] AS [e]
WHERE CASE WHEN (
    [e].[BoolA] <> [e].[BoolB]) THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END <> CASE WHEN (
    [e].[IntA] = [e].[IntB]) THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END

SELECT [e].[Id]
FROM [NullSemanticsEntity1] AS [e]
WHERE CASE WHEN (
    ([e].[NullableBoolA] <> [e].[BoolB]) OR [e].[NullableBoolA] IS NULL) THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END <> CASE WHEN (
    ([e].[IntA] = [e].[NullableIntB]) AND [e].[NullableIntB] IS NOT NULL) THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END

SELECT [e].[Id]
FROM [NullSemanticsEntity1] AS [e]
WHERE CASE WHEN (
    (([e].[NullableBoolA] <> [e].[NullableBoolB]) OR [e].[NullableBoolA] IS NULL OR [e].[NullableBoolB] IS NULL) AND ([e].[NullableBoolA] IS NOT NULL OR [e].[NullableBoolB] IS NOT NULL)) THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END <> CASE WHEN (
    (([e].[NullableIntA] = [e].[NullableIntB]) AND [e].[NullableIntA] IS NOT NULL AND [e].[NullableIntB] IS NOT NULL) OR ([e].[NullableIntA] IS NULL AND [e].[NullableIntB] IS NULL)) THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END",
                Sql);
        }

        public override void Compare_complex_not_equal_equal_not_equal()
        {
            base.Compare_complex_not_equal_equal_not_equal();

            Assert.Equal(
                @"SELECT [e].[Id]
FROM [NullSemanticsEntity1] AS [e]
WHERE CASE WHEN (
    [e].[BoolA] <> [e].[BoolB]) THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END = CASE WHEN (
    [e].[IntA] <> [e].[IntB]) THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END

SELECT [e].[Id]
FROM [NullSemanticsEntity1] AS [e]
WHERE CASE WHEN (
    ([e].[NullableBoolA] <> [e].[BoolB]) OR [e].[NullableBoolA] IS NULL) THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END = CASE WHEN (
    ([e].[IntA] <> [e].[NullableIntB]) OR [e].[NullableIntB] IS NULL) THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END

SELECT [e].[Id]
FROM [NullSemanticsEntity1] AS [e]
WHERE CASE WHEN (
    (([e].[NullableBoolA] <> [e].[NullableBoolB]) OR [e].[NullableBoolA] IS NULL OR [e].[NullableBoolB] IS NULL) AND ([e].[NullableBoolA] IS NOT NULL OR [e].[NullableBoolB] IS NOT NULL)) THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END = CASE WHEN (
    (([e].[NullableIntA] <> [e].[NullableIntB]) OR [e].[NullableIntA] IS NULL OR [e].[NullableIntB] IS NULL) AND ([e].[NullableIntA] IS NOT NULL OR [e].[NullableIntB] IS NOT NULL)) THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END",
                Sql);
        }

        public override void Compare_complex_not_equal_not_equal_not_equal()
        {
            base.Compare_complex_not_equal_not_equal_not_equal();

            Assert.Equal(
                @"SELECT [e].[Id]
FROM [NullSemanticsEntity1] AS [e]
WHERE CASE WHEN (
    [e].[BoolA] <> [e].[BoolB]) THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END <> CASE WHEN (
    [e].[IntA] <> [e].[IntB]) THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END

SELECT [e].[Id]
FROM [NullSemanticsEntity1] AS [e]
WHERE CASE WHEN (
    ([e].[NullableBoolA] <> [e].[BoolB]) OR [e].[NullableBoolA] IS NULL) THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END <> CASE WHEN (
    ([e].[IntA] <> [e].[NullableIntB]) OR [e].[NullableIntB] IS NULL) THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END

SELECT [e].[Id]
FROM [NullSemanticsEntity1] AS [e]
WHERE CASE WHEN (
    (([e].[NullableBoolA] <> [e].[NullableBoolB]) OR [e].[NullableBoolA] IS NULL OR [e].[NullableBoolB] IS NULL) AND ([e].[NullableBoolA] IS NOT NULL OR [e].[NullableBoolB] IS NOT NULL)) THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END <> CASE WHEN (
    (([e].[NullableIntA] <> [e].[NullableIntB]) OR [e].[NullableIntA] IS NULL OR [e].[NullableIntB] IS NULL) AND ([e].[NullableIntA] IS NOT NULL OR [e].[NullableIntB] IS NOT NULL)) THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END",
                Sql);
        }

        public override void Compare_nullable_with_null_parameter_equal()
        {
            base.Compare_nullable_with_null_parameter_equal();

            Assert.Equal(
                @"SELECT [e].[Id]
FROM [NullSemanticsEntity1] AS [e]
WHERE [e].[NullableStringA] IS NULL",
                Sql);
        }

        public override void Compare_nullable_with_non_null_parameter_not_equal()
        {
            base.Compare_nullable_with_non_null_parameter_not_equal();

            Assert.Equal(
                @"__prm_0: Foo

SELECT [e].[Id]
FROM [NullSemanticsEntity1] AS [e]
WHERE [e].[NullableStringA] = @__prm_0",
                Sql);
        }

        private static string Sql
        {
            get { return TestSqlLoggerFactory.Sql; }
        }
    }
}

